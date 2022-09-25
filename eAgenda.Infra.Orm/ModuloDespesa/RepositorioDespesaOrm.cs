using eAgenda.Dominio;
using eAgenda.Dominio.ModuloDespesa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Orm.ModuloDespesa
{
    public class RepositorioDespesaOrm : IRepositorioDespesa
    {
        private DbSet<Despesa> despesas;
        private readonly eAgendaDbContext dbContext;

        public RepositorioDespesaOrm(IContextoPersistencia contextoPersistencia)
        {
            dbContext = (eAgendaDbContext)contextoPersistencia;
            despesas = dbContext.Set<Despesa>();
        }

        public void Inserir(Despesa novoRegistro)
        {
            despesas.Add(novoRegistro);
        }

        public void Inserir(Despesa novoRegistro, List<Categoria> categoriasMarcadas)
        {
            throw new NotImplementedException();
        }

        public void Editar(Despesa novoRegistro, List<Categoria> categoriasMarcadas, List<Categoria> categoriasDesmarcadas)
        {
            throw new NotImplementedException();
        }

        public void Editar(Despesa registro)
        {
            despesas.Update(registro);
        }

        public void Excluir(Despesa registro)
        {
            despesas.Remove(registro);
        }

        public Despesa SelecionarPorId(Guid id)
        {
            return despesas
                .Include(x => x.Categorias)
                .SingleOrDefault(x => x.Id == id);
        }

        public List<Despesa> SelecionarTodos()
        {
            return despesas.ToList();
        }
    }
}
