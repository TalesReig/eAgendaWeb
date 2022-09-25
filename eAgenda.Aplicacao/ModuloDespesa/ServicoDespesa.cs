using eAgenda.Dominio;
using eAgenda.Dominio.ModuloDespesa;
using FluentResults;
using Serilog;
using System;
using System.Collections.Generic;

namespace eAgenda.Aplicacao.ModuloDespesa
{
    public class ServicoDespesa : ServicoBase<Despesa, ValidadorDespesa>
    {
        private IRepositorioDespesa repositorioDespesa;
        private IContextoPersistencia contextoPersistencia;

        public ServicoDespesa(IRepositorioDespesa repositorioDespesa,
                             IContextoPersistencia contexto)
        {
            this.repositorioDespesa = repositorioDespesa;
            this.contextoPersistencia = contexto;
        }

        public Result<Despesa> Inserir(Despesa despesa, List<Categoria> categorias)
        {
            throw new NotImplementedException();
        }

        public Result<Despesa> Editar(Despesa despesa, List<Categoria> categorias1, List<Categoria> categorias2)
        {
            throw new NotImplementedException();
        }

        public Result<Despesa> Inserir(Despesa despesa)
        {
            Log.Logger.Debug("Tentando inserir despesa... {@d}", despesa);

            Result resultado = Validar(despesa);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioDespesa.Inserir(despesa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Despesa {DespesaId} inserida com sucesso", despesa.Id);

                return Result.Ok(despesa);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar inserir a Despesa";

                Log.Logger.Error(ex, msgErro + " {DespesaId} ", despesa.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<Despesa> Editar(Despesa despesa)
        {
            Log.Logger.Debug("Tentando editar despesa... {@d}", despesa);

            var resultado = Validar(despesa);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioDespesa.Editar(despesa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Despesa {DespesaId} editada com sucesso", despesa.Id);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar editar a Despesa";

                Log.Logger.Error(ex, msgErro + " {DespesaId}", despesa.Id);

                return Result.Fail(msgErro);
            }

            return Result.Ok(despesa);
        }

        public Result Excluir(Despesa despesa)
        {
            Log.Logger.Debug("Tentando excluir despesa... {@d}", despesa);

            try
            {
                repositorioDespesa.Excluir(despesa);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Despesa {DespesaId} editada com sucesso", despesa.Id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar excluir a Despesa";

                Log.Logger.Error(ex, msgErro + " {DespesaId}", despesa.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<List<Despesa>> SelecionarTodos()
        {
            Log.Logger.Debug("Tentando selecionar despesas...");

            try
            {
                var despesas = repositorioDespesa.SelecionarTodos();

                Log.Logger.Information("Despesas selecionadas com sucesso");

                return Result.Ok(despesas);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar todas as Despesas";

                Log.Logger.Error(ex, msgErro);

                return Result.Fail(msgErro);
            }
        }

        public Result<Despesa> SelecionarPorId(Guid id)
        {
            Log.Logger.Debug("Tentando selecionar despesa {DespesaId}...", id);

            try
            {
                var despesa = repositorioDespesa.SelecionarPorId(id);

                if (despesa == null)
                {
                    Log.Logger.Warning("Despesa {DespesaId} não encontrada", id);

                    return Result.Fail("Despesa não encontrada");
                }

                Log.Logger.Information("Despesa {DespesaId} selecionada com sucesso", id);

                return Result.Ok(despesa);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar o Despesa";

                Log.Logger.Error(ex, msgErro + " {DespesaId}", id);

                return Result.Fail(msgErro);
            }
        }
    }
}
