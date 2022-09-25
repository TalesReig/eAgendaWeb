using eAgenda.Dominio;
using eAgenda.Dominio.ModuloCompromisso;
using FluentResults;
using Serilog;
using System;
using System.Collections.Generic;

namespace eAgenda.Aplicacao.ModuloCompromisso
{
    public class ServicoCompromisso : ServicoBase<Compromisso, ValidadorCompromisso>
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private IContextoPersistencia contextoPersistencia;

        public ServicoCompromisso(IRepositorioCompromisso repositorioCompromisso,
                             IContextoPersistencia contexto)
        {
            this.repositorioCompromisso = repositorioCompromisso;
            this.contextoPersistencia = contexto;
        }

        public Result<Compromisso> Inserir(Compromisso compromisso)
        {
            Log.Logger.Debug("Tentando inserir compromisso... {@c}", compromisso);

            Result resultado = Validar(compromisso);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCompromisso.Inserir(compromisso);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Compromisso {CompromissoId} inserido com sucesso", compromisso.Id);

                return Result.Ok(compromisso);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar inserir o Compromisso";

                Log.Logger.Error(ex, msgErro + " {CompromissoId} ", compromisso.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<Compromisso> Editar(Compromisso compromisso)
        {
            Log.Logger.Debug("Tentando editar compromisso... {@c}", compromisso);

            var resultado = Validar(compromisso);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCompromisso.Editar(compromisso);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Compromisso {CompromissoId} editado com sucesso", compromisso.Id);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar editar o Compromisso";

                Log.Logger.Error(ex, msgErro + " {CompromissoId}", compromisso.Id);

                return Result.Fail(msgErro);
            }

            return Result.Ok(compromisso);
        }

        public Result Excluir(Compromisso compromisso)
        {
            Log.Logger.Debug("Tentando excluir compromisso... {@c}", compromisso);

            try
            {
                repositorioCompromisso.Excluir(compromisso);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Compromisso {CompromissoId} editado com sucesso", compromisso.Id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar excluir o Compromisso";

                Log.Logger.Error(ex, msgErro + " {CompromissoId}", compromisso.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<List<Compromisso>> SelecionarTodos()
        {
            Log.Logger.Debug("Tentando selecionar compromissos...");

            try
            {
                var compromissos = repositorioCompromisso.SelecionarTodos();

                Log.Logger.Information("Compromissos selecionados com sucesso");

                return Result.Ok(compromissos);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar todos os Compromissos";

                Log.Logger.Error(ex, msgErro);

                return Result.Fail(msgErro);
            }
        }

        public Result<Compromisso> SelecionarPorId(Guid id)
        {
            Log.Logger.Debug("Tentando selecionar compromisso {CompromissoId}...", id);

            try
            {
                var compromisso = repositorioCompromisso.SelecionarPorId(id);

                if (compromisso == null)
                {
                    Log.Logger.Warning("Compromisso {CompromissoId} não encontrado", id);

                    return Result.Fail("Compromisso não encontrado");
                }

                Log.Logger.Information("Compromisso {CompromissoId} selecionado com sucesso", id);

                return Result.Ok(compromisso);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar o Compromisso";

                Log.Logger.Error(ex, msgErro + " {CompromissoId}", id);

                return Result.Fail(msgErro);
            }
        }

        public Result<List<Compromisso>> SelecionarCompromissosPassados(DateTime now)
        {
            return SelecionarTodos();
        }

        public Result<List<Compromisso>> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            return SelecionarTodos();
        }
    }
}
