using eAgenda.Dominio.ModuloTarefa;
using FluentResults;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaCadastroTarefasForm : Form // View
    {
        private Tarefa tarefa;

        public TelaCadastroTarefasForm()
        {
            InitializeComponent();

            CarregarPrioridades();
        }

        private void CarregarPrioridades()
        {
            var prioridades = Enum.GetValues(typeof(PrioridadeTarefaEnum));

            foreach (var item in prioridades)
            {
                cmbPrioridades.Items.Add(item);
            }

            cmbPrioridades.SelectedItem = PrioridadeTarefaEnum.Baixa;
        }

        public Func<Tarefa, Result<Tarefa>> GravarRegistro { get; set; }


        public Tarefa Tarefa
        {
            get
            {
                return tarefa;
            }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Id.ToString();
                txtTitulo.Text = tarefa.Titulo;
                cmbPrioridades.SelectedItem = tarefa.Prioridade;

                foreach (var item in tarefa.Itens)
                    listItensTarefa.Items.Add(item);

            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txtTitulo.Text;

            tarefa.Prioridade = (PrioridadeTarefaEnum)cmbPrioridades.SelectedItem;

            var resultadoValidacao = GravarRegistro(tarefa);

            if (resultadoValidacao.IsFailed)
            {
                string erro = resultadoValidacao.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroTarefasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroTarefasForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            ItemTarefa item = new ItemTarefa();

            item.Titulo = txtTituloItem.Text;

            tarefa.AdicionarItem(item);

            listItensTarefa.Items.Add(item);
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            var itemTarefa = listItensTarefa.SelectedItem as ItemTarefa;

            if (itemTarefa != null)
            {
                tarefa.RemoverItem(itemTarefa.Id);

                listItensTarefa.Items.Remove(itemTarefa);
            }
        }
    }
}
