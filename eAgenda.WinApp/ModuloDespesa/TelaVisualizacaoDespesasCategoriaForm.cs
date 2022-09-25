using eAgenda.Dominio.ModuloDespesa;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaVisualizacaoDespesasCategoriaForm : Form
    {
        public TelaVisualizacaoDespesasCategoriaForm(Categoria categoriaDespesaSelecionada)
        {
            InitializeComponent();
            labelTituloTarefa.Text = categoriaDespesaSelecionada.Titulo;

            foreach (var item in categoriaDespesaSelecionada.Despesas)
            {
                listDespesas.Items.Add(item);
            }
        }
    }
}
