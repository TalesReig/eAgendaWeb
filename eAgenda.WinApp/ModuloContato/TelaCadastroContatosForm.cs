using eAgenda.Dominio.ModuloContato;
using FluentResults;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaCadastroContatosForm : Form
    {
        public TelaCadastroContatosForm()
        {
            InitializeComponent();
        }

        private Contato contato;

        public Func<Contato, Result<Contato>> GravarRegistro { get; set; }

        public Contato Contato
        {
            get { return contato; }
            set
            {
                contato = value;

                txtNumero.Text = contato.Id.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtTelefone.Text = contato.Telefone;
                txtEmpresa.Text = contato.Empresa;
                txtCargo.Text = contato.Cargo;
            }
        }

        private void btnGravar_Click(object sender, System.EventArgs e)
        {
            contato.Nome = txtNome.Text;
            contato.Email = txtEmail.Text;
            contato.Telefone = txtTelefone.Text;
            contato.Empresa = txtEmpresa.Text;
            contato.Cargo = txtCargo.Text;

            var resultadoValidacao = GravarRegistro(contato);

            if (resultadoValidacao.IsFailed)
            {
                string erro = resultadoValidacao.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(erro);

                DialogResult = DialogResult.None;
            }
        }

        private void TelaCadastroContatosForm_Load(object sender, EventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }

        private void TelaCadastroContatosForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaPrincipalForm.Instancia.AtualizarRodape("");
        }
    }
}
