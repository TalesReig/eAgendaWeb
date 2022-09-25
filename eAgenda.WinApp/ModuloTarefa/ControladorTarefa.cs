using eAgenda.Aplicacao.ModuloTarefa;
using eAgenda.Dominio.ModuloTarefa;
using eAgenda.WinApp.Compartilhado;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private ServicoTarefa servicoTarefa;
        private TabelaTarefasControl tabelaTarefas;

        public StatusTarefaEnum StatusSelecionado { get; private set; }

        public ControladorTarefa(ServicoTarefa servicoTarefa)
        {
            this.servicoTarefa = servicoTarefa;
        }

        public override void Inserir()
        {
            TelaCadastroTarefasForm tela = new TelaCadastroTarefasForm();
            tela.Tarefa = new Tarefa();

            tela.GravarRegistro = servicoTarefa.Inserir;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTarefas();
            }
        }

        public override void Editar()
        {
            Tarefa tarefaSelecionada = ObtemTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaCadastroTarefasForm tela = new TelaCadastroTarefasForm();

            tela.Tarefa = tarefaSelecionada;

            tela.GravarRegistro = servicoTarefa.Editar;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                CarregarTarefas();
            }
        }

        public override void Excluir()
        {
            Tarefa tarefaSelecionada = ObtemTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                servicoTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        public override void AtualizarItens()
        {
            Tarefa tarefaSelecionada = ObtemTarefaSelecionada();

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TelaAtualizacaoItensTarefaForm tela = new TelaAtualizacaoItensTarefaForm(tarefaSelecionada);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                servicoTarefa.AtualizarItens(tarefaSelecionada,
                    tela.ItensConcluidos, tela.ItensPendentes);

                CarregarTarefas();
            }
        }

        public override void Filtrar()
        {
            TelaFiltroTarefaForm telaFiltro = new TelaFiltroTarefaForm();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusSelecionado = telaFiltro.StatusSelecionado;

                CarregarTarefas();
            }
        }

        public override UserControl ObtemListagem()
        {
            if (tabelaTarefas == null)
                tabelaTarefas = new TabelaTarefasControl();

            CarregarTarefas();

            return tabelaTarefas;
        }

        public override ConfiguracaoToolboxBase ObtemConfiguracaoToolbox()
        {
            return new ConfiguracaoToolboxTarefa();
        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = servicoTarefa.SelecionarTodos(StatusSelecionado).Value;

            string tipoTarefa;

            switch (StatusSelecionado)
            {
                case StatusTarefaEnum.Pendentes: tipoTarefa = "pendente(s)"; break;

                case StatusTarefaEnum.Concluidas: tipoTarefa = "concluída(s)"; break;

                default: tipoTarefa = ""; break;
            }

            tabelaTarefas.AtualizarRegistros(tarefas);
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {tarefas.Count} tarefa(s) {tipoTarefa}");
        }

        private Tarefa ObtemTarefaSelecionada()
        {
            var numero = tabelaTarefas.ObtemNumeroTarefaSelecionado();

            return servicoTarefa.SelecionarPorId(numero).Value;
        }
    }
}
