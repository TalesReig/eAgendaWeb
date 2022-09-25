using eAgenda.Dominio;
using eAgenda.Dominio.ModuloTarefa;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Infra.Orm.ModuloTarefa
{
    public class RepositorioTarefaOrm : IRepositorioTarefa
    {
        private DbSet<Tarefa> tarefas;
        private readonly eAgendaDbContext dbContext;

        public RepositorioTarefaOrm(IContextoPersistencia contextoPersistencia)
        {
            dbContext = (eAgendaDbContext)contextoPersistencia;
            tarefas = dbContext.Set<Tarefa>();
        }

        public void Inserir(Tarefa novoRegistro)
        {
            tarefas.Add(novoRegistro);
        }

        public void Editar(Tarefa registro)
        {
            tarefas.Update(registro);
        }

        public void Excluir(Tarefa registro)
        {
            tarefas.Remove(registro);
        }

        public Tarefa SelecionarPorId(Guid id)
        {
            return tarefas
                .Include(x => x.Itens)
                .SingleOrDefault(x => x.Id == id);
        }

        public List<Tarefa> SelecionarTodos()
        {
            return tarefas.ToList();
        }

        public List<Tarefa> SelecionarTodos(StatusTarefaEnum status)
        {
            if (status == StatusTarefaEnum.Concluidas)
                return tarefas.Where(x => x.PercentualConcluido == 100).ToList();

            else if (status == StatusTarefaEnum.Pendentes)
                return tarefas.Where(x => x.PercentualConcluido < 100).ToList();

            else
                return tarefas.ToList();
        }
    }
}
