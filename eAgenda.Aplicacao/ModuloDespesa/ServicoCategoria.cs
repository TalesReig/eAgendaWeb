using eAgenda.Dominio;
using eAgenda.Dominio.ModuloDespesa;
using FluentResults;
using Serilog;
using System;
using System.Collections.Generic;

namespace eAgenda.Aplicacao.ModuloDespesa
{
    public class ServicoCategoria : ServicoBase<Categoria, ValidadorCategoria>
    {
        private IRepositorioCategoria repositorioCategoria;
        private IContextoPersistencia contextoPersistencia;

        public ServicoCategoria(IRepositorioCategoria repositorioCategoria,
                             IContextoPersistencia contexto)
        {
            this.repositorioCategoria = repositorioCategoria;
            this.contextoPersistencia = contexto;
        }

        public Result<Categoria> Inserir(Categoria categoria)
        {
            Log.Logger.Debug("Tentando inserir categoria... {@c}", categoria);

            Result resultado = Validar(categoria);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCategoria.Inserir(categoria);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Categoria {CategoriaId} inserida com sucesso", categoria.Id);

                return Result.Ok(categoria);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar inserir a Categoria";

                Log.Logger.Error(ex, msgErro + " {CategoriaId} ", categoria.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<Categoria> Editar(Categoria categoria)
        {
            Log.Logger.Debug("Tentando editar categoria... {@c}", categoria);

            var resultado = Validar(categoria);

            if (resultado.IsFailed)
                return Result.Fail(resultado.Errors);

            try
            {
                repositorioCategoria.Editar(categoria);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Categoria {CategoriaId} editada com sucesso", categoria.Id);
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar editar a Categoria";

                Log.Logger.Error(ex, msgErro + " {CategoriaId}", categoria.Id);

                return Result.Fail(msgErro);
            }

            return Result.Ok(categoria);
        }

        public Result Excluir(Categoria categoria)
        {
            Log.Logger.Debug("Tentando excluir categoria... {@c}", categoria);

            try
            {
                repositorioCategoria.Excluir(categoria);

                contextoPersistencia.GravarDados();

                Log.Logger.Information("Categoria {CategoriaId} editada com sucesso", categoria.Id);

                return Result.Ok();
            }
            catch (Exception ex)
            {
                contextoPersistencia.DesfazerAlteracoes();

                string msgErro = "Falha no sistema ao tentar excluir a Categoria";

                Log.Logger.Error(ex, msgErro + " {CategoriaId}", categoria.Id);

                return Result.Fail(msgErro);
            }
        }

        public Result<List<Categoria>> SelecionarTodos()
        {
            Log.Logger.Debug("Tentando selecionar categorias...");

            try
            {
                var categorias = repositorioCategoria.SelecionarTodos();

                Log.Logger.Information("Categorias selecionadas com sucesso");

                return Result.Ok(categorias);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar todas as Categorias";

                Log.Logger.Error(ex, msgErro);

                return Result.Fail(msgErro);
            }
        }

        public Result<Categoria> SelecionarPorId(Guid id)
        {
            Log.Logger.Debug("Tentando selecionar categoria {CategoriaId}...", id);

            try
            {
                var categoria = repositorioCategoria.SelecionarPorId(id);

                if (categoria == null)
                {
                    Log.Logger.Warning("Categoria {CategoriaId} não encontrada", id);

                    return Result.Fail("Categoria não encontrada");
                }

                Log.Logger.Information("Categoria {CategoriaId} selecionada com sucesso", id);

                return Result.Ok(categoria);
            }
            catch (Exception ex)
            {
                string msgErro = "Falha no sistema ao tentar selecionar o Categoria";

                Log.Logger.Error(ex, msgErro + " {CategoriaId}", id);

                return Result.Fail(msgErro);
            }
        }
    }
}
