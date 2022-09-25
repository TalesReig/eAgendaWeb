using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace eAgenda.Dominio.ModuloTarefa.Tests
{
    [TestClass]
    public class TarefaTest
    {
        [TestMethod]
        public void Deve_adicionar_itens_na_tarefa()
        {
            //arrange
            var tarefa = new Tarefa();

            var item01 = new ItemTarefa("Item 01");
            var item02 = new ItemTarefa("Item 02");
            var item03 = new ItemTarefa("Item 03");
            var item04 = new ItemTarefa("Item 04");

            //action
            tarefa.AdicionarItem(item01);
            tarefa.AdicionarItem(item02);
            tarefa.AdicionarItem(item03);
            tarefa.AdicionarItem(item04);

            //assert
            Assert.AreEqual(4, tarefa.Itens.Count);
        }

        [TestMethod]
        public void Nao_deve_adicionar_itens_duplicados_na_tarefa()
        {
            //arrange
            var t = new Tarefa();

            var idDuplicado = Guid.NewGuid();

            var item01 = new ItemTarefa("Item 01");
            item01.Id = idDuplicado;

            var item02 = new ItemTarefa("Item 01");
            item02.Id = idDuplicado;

            var item03 = new ItemTarefa("Item 01");
            item03.Id = idDuplicado;

            var item04 = new ItemTarefa("Item 04");

            //action
            t.AdicionarItem(item01);
            t.AdicionarItem(item02);
            t.AdicionarItem(item03);
            t.AdicionarItem(item04);

            //assert
            Assert.AreEqual(2, t.Itens.Count);
        }

        [TestMethod]
        public void Deve_concluir_itens_da_tarefa()
        {
            //arrange
            var t = new Tarefa();

            var item01 = new ItemTarefa("Item 01");
            var item02 = new ItemTarefa("Item 02");
            var item03 = new ItemTarefa("Item 03");
            var item04 = new ItemTarefa("Item 04");

            t.AdicionarItem(item01);
            t.AdicionarItem(item02);
            t.AdicionarItem(item03);
            t.AdicionarItem(item04);

            //action
            t.ConcluirItem(item01.Id);
            t.ConcluirItem(item02.Id);
            t.ConcluirItem(item03.Id);
            t.ConcluirItem(item04.Id);

            //assert
            Assert.AreEqual(true, item01.Concluido);
            Assert.AreEqual(true, item02.Concluido);
            Assert.AreEqual(true, item03.Concluido);
            Assert.AreEqual(true, item04.Concluido);

            Assert.AreEqual(DateTime.Now.Date, t.DataConclusao);
        }

        [TestMethod]
        public void Deve_calcular_percentual_concluido_da_tarefa()
        {
            //arrange
            var t = new Tarefa();

            var item01 = new ItemTarefa("Item 01");
            var item02 = new ItemTarefa("Item 02");
            var item03 = new ItemTarefa("Item 03");
            var item04 = new ItemTarefa("Item 04");

            t.AdicionarItem(item01);
            t.AdicionarItem(item02);
            t.AdicionarItem(item03);
            t.AdicionarItem(item04);

            t.ConcluirItem(item01.Id);
            t.ConcluirItem(item02.Id);

            //action
            t.CalcularPercentualConcluido();

            //assert
            Assert.AreEqual(50, t.PercentualConcluido);
        }

        [TestMethod]
        public void Deve_marcar_item_da_tarefa_como_pendente()
        {
            //arrange
            var t = new Tarefa();

            var item01 = new ItemTarefa("Item 01");

            t.AdicionarItem(item01);
            t.ConcluirItem(item01.Id);

            //action
            t.MarcarPendente(item01.Id);

            //assert
            Assert.AreEqual(false, item01.Concluido);
        }

        [TestMethod]
        public void Nao_deve_mostrar_data_conclusao_da_tarefa()
        {
            //arrange
            var t = new Tarefa();

            var id = t.Id;
            t.Titulo = "Tarefa 01";
            t.Prioridade = PrioridadeTarefaEnum.Alta;

            var item01 = new ItemTarefa("Item 01");
            var item02 = new ItemTarefa("Item 02");

            t.AdicionarItem(item01);
            t.AdicionarItem(item02);

            t.ConcluirItem(item01.Id);

            //action
            var resultado = t.ToString();

            //assert
            var resultadoEsperado =
                $"Número: {id}, Título: Tarefa 01, Percentual: 50,0, Prioridade: Alta";

            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void Deve_mostrar_data_conclusao_da_tarefa()
        {
            //arrange
            var t = new Tarefa();

            var id = t.Id;
            t.Titulo = "Tarefa 01";
            t.Prioridade = PrioridadeTarefaEnum.Alta;

            var item01 = new ItemTarefa("Item 01");
            var item02 = new ItemTarefa("Item 02");

            t.AdicionarItem(item01);
            t.AdicionarItem(item02);

            t.ConcluirItem(item01.Id);
            t.ConcluirItem(item02.Id);

            //action
            var resultado = t.ToString();

            //assert
            var resultadoEsperado =
                $"Número: {id}, Título: Tarefa 01, Percentual: 100, Prioridade: Alta, Concluída: {DateTime.Now.ToShortDateString()}";

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
