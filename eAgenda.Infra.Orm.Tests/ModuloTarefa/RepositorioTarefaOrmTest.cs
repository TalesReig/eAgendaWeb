using eAgenda.Dominio.ModuloTarefa;
using eAgenda.Infra.Configs;
using eAgenda.Infra.Orm;
using eAgenda.Infra.Orm.ModuloTarefa;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace eAgenda.Infra.BancoDados.Tests.ModuloTarefa
{
    [TestClass]
    public class RepositorioTarefaOrmTest
    {
        private readonly eAgendaDbContext db;

        public RepositorioTarefaOrmTest()
        {
            var config = new ConfiguracaoAplicacaoeAgenda();

            db = new eAgendaDbContext(config.ConnectionStrings);

            db.Set<ItemTarefa>().RemoveRange(db.Set<ItemTarefa>());
            db.Set<Tarefa>().RemoveRange(db.Set<Tarefa>());

            db.SaveChanges();
        }

        [TestMethod]
        public void Deve_inserir_tarefa()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");

            var repositorio = new RepositorioTarefaOrm(db);

            //action
            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            //assert
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            Assert.IsNotNull(tarefaEncontrada);
            Assert.AreEqual(novaTarefa.Id, tarefaEncontrada.Id);
            Assert.AreEqual(novaTarefa.Titulo, tarefaEncontrada.Titulo);
            Assert.AreEqual(novaTarefa.Prioridade, tarefaEncontrada.Prioridade);
            Assert.AreEqual(novaTarefa.DataCriacao.Date, tarefaEncontrada.DataCriacao.Date);
            Assert.AreEqual(novaTarefa.DataConclusao, tarefaEncontrada.DataConclusao);
            Assert.AreEqual(novaTarefa.PercentualConcluido, tarefaEncontrada.PercentualConcluido);

            Assert.AreEqual(0, novaTarefa.Itens.Count);
        }

        [TestMethod]
        public void Deve_adicionar_itens_na_tarefa()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");

            var repositorio = new RepositorioTarefaOrm(db);


            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                novaTarefa.AdicionarItem(item);
            }

            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            //action
            repositorio.Inserir(novaTarefa);

            //assert
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            Assert.IsNotNull(tarefaEncontrada);
            Assert.AreEqual(novaTarefa.Id, tarefaEncontrada.Id);
            Assert.AreEqual(novaTarefa.Titulo, tarefaEncontrada.Titulo);
            Assert.AreEqual(novaTarefa.Prioridade, tarefaEncontrada.Prioridade);
            Assert.AreEqual(novaTarefa.DataCriacao.Date, tarefaEncontrada.DataCriacao.Date);
            Assert.AreEqual(novaTarefa.DataConclusao, tarefaEncontrada.DataConclusao);
            Assert.AreEqual(novaTarefa.PercentualConcluido, tarefaEncontrada.PercentualConcluido);

            Assert.AreEqual(4, tarefaEncontrada.Itens.Count);
        }

        [TestMethod]
        public void Deve_editar_tarefa()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");
            var repositorio = new RepositorioTarefaOrm(db);
            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            Tarefa tarefaAtualizada = repositorio.SelecionarPorId(novaTarefa.Id);
            tarefaAtualizada.Titulo = "Preparar palestra";
            tarefaAtualizada.Prioridade = PrioridadeTarefaEnum.Alta;

            //action
            repositorio.Editar(tarefaAtualizada);
            db.SaveChanges();

            //assert
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            Assert.IsNotNull(tarefaEncontrada);
            Assert.AreEqual(tarefaAtualizada.Id, tarefaEncontrada.Id);
            Assert.AreEqual(tarefaAtualizada.Titulo, tarefaEncontrada.Titulo);
            Assert.AreEqual(tarefaAtualizada.Prioridade, tarefaEncontrada.Prioridade);
            Assert.AreEqual(tarefaAtualizada.DataCriacao.Date, tarefaEncontrada.DataCriacao.Date);
            Assert.AreEqual(tarefaAtualizada.DataConclusao, tarefaEncontrada.DataConclusao);
            Assert.AreEqual(tarefaAtualizada.PercentualConcluido, tarefaEncontrada.PercentualConcluido);
        }

        [TestMethod]
        public void Deve_atualizar_itens_na_tarefa()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");
            var repositorio = new RepositorioTarefaOrm(db);

            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                novaTarefa.AdicionarItem(item);
            }

            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            Tarefa tarefaAtualizada = repositorio.SelecionarPorId(novaTarefa.Id);
            tarefaAtualizada.Titulo = "Preparar palestra";
            tarefaAtualizada.Prioridade = PrioridadeTarefaEnum.Alta;

            var itensConcluidos = new List<ItemTarefa>();
            itensConcluidos.Add(tarefaAtualizada.Itens[0]);
            itensConcluidos.Add(tarefaAtualizada.Itens[1]);

            var itensPendentes = new List<ItemTarefa>();
            itensPendentes.Add(tarefaAtualizada.Itens[2]);
            itensPendentes.Add(tarefaAtualizada.Itens[3]);

            //action
            repositorio.Editar(tarefaAtualizada);
            db.SaveChanges();

            //assert
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            Assert.IsNotNull(tarefaEncontrada);
            Assert.AreEqual(tarefaAtualizada.Id, tarefaEncontrada.Id);
            Assert.AreEqual(tarefaAtualizada.Titulo, tarefaEncontrada.Titulo);
            Assert.AreEqual(tarefaAtualizada.Prioridade, tarefaEncontrada.Prioridade);
            Assert.AreEqual(tarefaAtualizada.DataCriacao.Date, tarefaEncontrada.DataCriacao.Date);
            Assert.AreEqual(tarefaAtualizada.DataConclusao, tarefaEncontrada.DataConclusao);
            Assert.AreEqual(tarefaAtualizada.PercentualConcluido, tarefaEncontrada.PercentualConcluido);
        }

        [TestMethod]
        public void Deve_excluir_tarefa_com_itens()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");

            var repositorio = new RepositorioTarefaOrm(db);

            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                novaTarefa.AdicionarItem(item);
            }

            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            //action
            repositorio.Excluir(novaTarefa);
            db.SaveChanges();

            //assert
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            Assert.IsNull(tarefaEncontrada);
        }

        [TestMethod]
        public void Deve_selecionar_uma_tarefa_e_seus_itens()
        {
            //arrange
            Tarefa novaTarefa = new Tarefa("Corrigir provas");

            var repositorio = new RepositorioTarefaOrm(db);

            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                novaTarefa.AdicionarItem(item);
            }

            repositorio.Inserir(novaTarefa);
            db.SaveChanges();

            //action
            Tarefa tarefaEncontrada = repositorio.SelecionarPorId(novaTarefa.Id);

            //assert
            Assert.IsNotNull(tarefaEncontrada);
            Assert.AreEqual(novaTarefa.Id, tarefaEncontrada.Id);
            Assert.AreEqual(novaTarefa.Titulo, tarefaEncontrada.Titulo);
            Assert.AreEqual(novaTarefa.Prioridade, tarefaEncontrada.Prioridade);
            Assert.AreEqual(novaTarefa.DataCriacao.Date, tarefaEncontrada.DataCriacao.Date);
            Assert.AreEqual(novaTarefa.DataConclusao, tarefaEncontrada.DataConclusao);
            Assert.AreEqual(novaTarefa.PercentualConcluido, tarefaEncontrada.PercentualConcluido);

            Assert.AreEqual(4, tarefaEncontrada.Itens.Count);
        }

        [TestMethod]
        public void Deve_selecionar_todas_tarefas()
        {
            //arrange
            var repositorio = new RepositorioTarefaOrm(db);

            Tarefa t1 = new Tarefa("Preparar aula");
            repositorio.Inserir(t1);

            Tarefa t2 = new Tarefa("Corrigir Provas");
            repositorio.Inserir(t2);

            Tarefa t3 = new Tarefa("Implementar Atividades");
            repositorio.Inserir(t3);
            db.SaveChanges();

            //action
            var tarefas = repositorio.SelecionarTodos();

            //assert
            Assert.AreEqual(3, tarefas.Count);

            Assert.AreEqual("Preparar aula", tarefas[0].Titulo);
            Assert.AreEqual("Corrigir Provas", tarefas[1].Titulo);
            Assert.AreEqual("Implementar Atividades", tarefas[2].Titulo);
        }

        [TestMethod]
        public void Deve_selecionar_apenas_tarefas_pendentes()
        {
            //arrange
            var repositorio = new RepositorioTarefaOrm(db);

            Tarefa t1 = new Tarefa("Preparar aula");
            repositorio.Inserir(t1);

            Tarefa t2 = new Tarefa("Corrigir Provas");
            repositorio.Inserir(t2);

            Tarefa t3 = new Tarefa("Implementar Atividades");

            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                t3.AdicionarItem(item);
            }

            repositorio.Inserir(t3);

            db.SaveChanges();

            foreach (var item in itens)
            {
                t3.ConcluirItem(item.Id);
            }

            repositorio.Editar(t3);
            db.SaveChanges();

            //action
            var tarefas = repositorio.SelecionarTodos(StatusTarefaEnum.Pendentes);

            //assert
            Assert.AreEqual(2, tarefas.Count);

            Assert.AreEqual("Preparar aula", tarefas[0].Titulo);
            Assert.AreEqual("Corrigir Provas", tarefas[1].Titulo);
        }

        [TestMethod]
        public void Deve_selecionar_apenas_tarefas_concluidas()
        {
            //arrange
            var repositorio = new RepositorioTarefaOrm(db);

            Tarefa t1 = new Tarefa("Preparar aula");
            repositorio.Inserir(t1);

            Tarefa t2 = new Tarefa("Corrigir Provas");
            repositorio.Inserir(t2);

            Tarefa t3 = new Tarefa("Implementar Atividades");

            var itens = new List<ItemTarefa>
            {
                new ItemTarefa("Item 01"),
                new ItemTarefa("Item 02"),
                new ItemTarefa("Item 03"),
                new ItemTarefa("Item 04")
            };

            foreach (var item in itens)
            {
                t3.AdicionarItem(item);
            }

            repositorio.Inserir(t3);

            db.SaveChanges();

            foreach (var item in itens)
            {
                t3.ConcluirItem(item.Id);
            }

            repositorio.Editar(t3);
            db.SaveChanges();

            //action
            var tarefas = repositorio.SelecionarTodos(StatusTarefaEnum.Concluidas);

            //assert
            Assert.AreEqual(1, tarefas.Count);

            Assert.AreEqual("Implementar Atividades", tarefas[0].Titulo);
        }

    }
}