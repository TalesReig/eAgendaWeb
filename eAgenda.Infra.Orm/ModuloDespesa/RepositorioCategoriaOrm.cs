using eAgenda.Dominio;
using eAgenda.Dominio.ModuloDespesa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Orm.ModuloDespesa
{
    public class RepositorioCategoriaOrm : IRepositorioCategoria
    {
        private DbSet<Categoria> categorias;
        private readonly eAgendaDbContext dbContext;

        public RepositorioCategoriaOrm(IContextoPersistencia contextoPersistencia)
        {
            dbContext = (eAgendaDbContext)contextoPersistencia;
            categorias = dbContext.Set<Categoria>();
        }

        public void Inserir(Categoria novoRegistro)
        {
            categorias.Add(novoRegistro);
        }

        public void Editar(Categoria registro)
        {
            categorias.Update(registro);
        }

        public void Excluir(Categoria registro)
        {
            categorias.Remove(registro);
        }

        public Categoria SelecionarPorId(Guid id)
        {
            return categorias.SingleOrDefault(x => x.Id == id);
        }

        public List<Categoria> SelecionarTodos(bool incluirMateriasEhQuestoes)
        {
            return categorias.ToList();
        }

        public List<Categoria> SelecionarTodos()
        {
            return categorias.ToList();
        }

    }
}
