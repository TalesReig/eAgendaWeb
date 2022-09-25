using eAgenda.Dominio;
using eAgenda.Dominio.ModuloTarefa;
using FluentResults;
using Serilog;
using System;
using System.Collections.Generic;

namespace eAgenda.Aplicacao.ModuloTarefa
{
    public class ServicoTarefa : ServicoBase<Tarefa, ValidadorTarefa>
    {
        private IRepositorioTarefa repositorioTarefa;
        private IContextoPersistencia contextoPersistencia;

        public ServicoTarefa(IRepositorioTarefa repositorioTarefa,
                             IContextoPersistencia contexto)
        {
            this.repositorioTarefa = repositorioTarefa;
            this.contextoPersistencia = contexto;
        }

        public Result<Tarefa> Inserir(Tarefa tarefa)
        {
            Log.Logger.Debug("Tentando inserir tarefa... {@t}", tarefa);

            Result resultado = Validar(tarefa);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {

                repositorioTarefa.Inserir(tarefa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Tarefa {TarefaId} inserida com sucesso", tarefa.Id);

                return Result.Ok(tarefa);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar inserir a Tarefa";

                Log.Logger.Error(ex, msgErro + " {TarefaId} ", tarefa.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<Tarefa> Editar(Tarefa tarefa)
        {
            Log.Logger.Debug("Tentando editar tarefa... {@t}", tarefa);

            var resultado = Validar(tarefa);
            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                tarefa.CalcularPercentualConcluido();

                repositorioTarefa.Editar(tarefa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Tarefa {TarefaId} editada com sucesso", tarefa.Id);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar editar a Tarefa";

                Log.Logger.Error(ex, msgErro + " {TarefaId}", tarefa.Id);

                return Result.Fail(msgErro);
            }

            return Result.Ok(tarefa);
        }

        public Result<Tarefa> AtualizarItens(Tarefa tarefa, List<ItemTarefa> itensConcluidos, List<ItemTarefa> itensPendentes)
        {
            foreach (var item in itensConcluidos)
                tarefa.ConcluirItem(item.Id);

            foreach (var item in itensPendentes)
                tarefa.MarcarPendente(item.Id);

            return Editar(tarefa);
        }

        public Result Excluir(Guid id)
        {
            var tarefaResult = SelecionarPorId(id);

            if (tarefaResult.IsSuccess)
                return Excluir(tarefaResult.Value);

            return Result.Fail(tarefaResult.Errors);
        }

        public Result Excluir(Tarefa tarefa)
        {
            Log.Logger.Debug("Tentando excluir tarefa... {@t}", tarefa);

            try
            {
                repositorioTarefa.Excluir(tarefa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Tarefa {TarefaId} editada com sucesso", tarefa.Id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar excluir a Tarefa";

                Log.Logger.Error(ex, msgErro + " {TarefaId}", tarefa.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<List<Tarefa>> SelecionarTodos(StatusTarefaEnum statusSelecionado)
        {
            Log.Logger.Debug("Tentando selecionar tarefas...");

            try
            {
                var tarefas = repositorioTarefa.SelecionarTodos(statusSelecionado);

                Log.Logger.Information("Tarefas selecionadas com sucesso");

                return Result.Ok(tarefas);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar todas as Tarefas";

                Log.Logger.Error(ex, msgErro);

                return Result.Fail(msgErro);
            }
        }

        public Result<Tarefa> SelecionarPorId(Guid id)
        {
            Log.Logger.Debug("Tentando selecionar tarefa {TarefaId}...", id);

            try
            {
                var tarefa = repositorioTarefa.SelecionarPorId(id);

                if (tarefa == null)
                {
                    Log.Logger.Warning("Tarefa {TarefaId} não encontrada", id);

                    return Result.Fail($"Tarefa {id} não encontrada");
                }

                Log.Logger.Information("Tarefa {TarefaId} selecionada com sucesso", id);

                return Result.Ok(tarefa);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar o Tarefa";

                Log.Logger.Error(ex, msgErro + " {TarefaId}", id);

                return Result.Fail(msgErro);
            }
        }
    }
}