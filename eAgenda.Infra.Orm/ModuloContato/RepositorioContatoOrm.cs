using eAgenda.Dominio;
using eAgenda.Dominio.ModuloContato;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Orm.ModuloContato
{
    public class RepositorioContatoOrm : IRepositorioContato
    {
        private DbSet<Contato> contatos;
        private readonly eAgendaDbContext dbContext;

        public RepositorioContatoOrm(IContextoPersistencia contextoPersistencia)
        {
            dbContext = (eAgendaDbContext)contextoPersistencia;
            contatos = dbContext.Set<Contato>();
        }

        public void Inserir(Contato novoRegistro)
        {
            contatos.Add(novoRegistro);
        }

        public void Editar(Contato registro)
        {
            contatos.Update(registro);
        }

        public void Excluir(Contato registro)
        {
            contatos.Remove(registro);
        }

        public Contato SelecionarPorId(Guid id)
        {
            return contatos.SingleOrDefault(x => x.Id == id);
        }

        public List<Contato> SelecionarTodos(bool incluirMateriasEhQuestoes)
        {
            return contatos.ToList();
        }

        public List<Contato> SelecionarTodos()
        {
            return contatos.ToList();
        }


    }
}
