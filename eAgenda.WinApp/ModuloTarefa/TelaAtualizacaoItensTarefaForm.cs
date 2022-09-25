using eAgenda.Dominio.ModuloTarefa;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizacaoItensTarefaForm : Form
    {
        private readonly Tarefa tarefa;

        public TelaAtualizacaoItensTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;

            labelTituloTarefa.Text = tarefa.Titulo;
            labelPrioridade.Text = tarefa.Prioridade.ToString();
            labelDataCriacao.Text = tarefa.DataCriacao.ToString();

            CarregarItensTarefa(tarefa);
        }

        private void CarregarItensTarefa(Tarefa tarefa)
        {
            int i = 0;
            foreach (var item in tarefa.Itens)
            {
                listItensTarefa.Items.Add(item);

                if (item.Concluido)
                    listItensTarefa.SetItemChecked(i, true);

                i++;
            }
        }

        public List<ItemTarefa> ItensConcluidos
        {
            get
            {
                return listItensTarefa.CheckedItems
                    .Cast<ItemTarefa>()
                    .ToList();
            }
        }

        public List<ItemTarefa> ItensPendentes
        {
            get
            {
                return listItensTarefa.Items
                    .Cast<ItemTarefa>()
                    .Except(ItensConcluidos)
                    .ToList();
            }
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            tarefa.CalcularPercentualConcluido();
        }
    }
}
