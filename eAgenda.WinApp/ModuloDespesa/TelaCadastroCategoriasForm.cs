using eAgenda.Dominio.ModuloDespesa;
using FluentResults;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaCadastroCategoriasForm : Form
    {
        private Categoria categoriaDespesa;

        public TelaCadastroCategoriasForm()
        {
            InitializeComponent();
        }

        public Func<Categoria, Result<Categoria>> GravarRegistro { get; set; }


        public Categoria Categoria
        {
            get
            {
                return categoriaDespesa;
            }
            set
            {
                categoriaDespesa = value;

                txtNumero.Text = categoriaDespesa.Id.ToString();
                txtTitulo.Text = categoriaDespesa.Titulo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            categoriaDespesa.Titulo = txtTitulo.Text;

            var resultadoValidacao = GravarRegistro(categoriaDespesa);

            if (resultadoValidacao.IsFailed)
            {
                string primeiroErro = resultadoValidacao.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }
    }
}
