using eAgenda.Dominio.ModuloTarefa;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefasControl : UserControl
    {
        public ListagemTarefasControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            CarregarTarefas(tarefas);
        }

        public Tarefa ObtemTarefaSelecionada()
        {
            return (Tarefa)listTarefas.SelectedItem;
        }

        private void CarregarTarefas(List<Tarefa> tarefas)
        {
            listTarefas.Items.Clear();

            foreach (Tarefa t in tarefas)
            {
                listTarefas.Items.Add(t);
            }
        }
    }
}
