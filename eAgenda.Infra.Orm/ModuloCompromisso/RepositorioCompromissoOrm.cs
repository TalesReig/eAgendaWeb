using eAgenda.Dominio;
using eAgenda.Dominio.ModuloCompromisso;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Orm.ModuloCompromisso
{
    public class RepositorioCompromissoOrm : IRepositorioCompromisso
    {
        private DbSet<Compromisso> compromissos;
        private readonly eAgendaDbContext dbContext;

        public RepositorioCompromissoOrm(IContextoPersistencia contextoPersistencia)
        {
            dbContext = (eAgendaDbContext)contextoPersistencia;
            compromissos = dbContext.Set<Compromisso>();
        }

        public void Inserir(Compromisso novoRegistro)
        {
            compromissos.Add(novoRegistro);
        }

        public void Editar(Compromisso registro)
        {
            compromissos.Update(registro);
        }

        public void Excluir(Compromisso registro)
        {
            compromissos.Remove(registro);
        }

        public Compromisso SelecionarPorId(Guid id)
        {
            return compromissos.SingleOrDefault(x => x.Id == id);
        }

        public List<Compromisso> SelecionarTodos()
        {
            return compromissos.ToList();
        }

        public List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal)
        {
            throw new NotImplementedException();
        }

        public List<Compromisso> SelecionarCompromissosPassados(DateTime dataDeHoje)
        {
            throw new NotImplementedException();
        }
    }
}