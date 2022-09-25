using eAgenda.Dominio.ModuloDespesa;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TelaCadastroDespesasForm : Form
    {
        private Despesa despesa;

        public TelaCadastroDespesasForm(List<Categoria> categorias)
        {
            InitializeComponent();

            CarregarFormaPgto();

            CarregarCategorias(categorias);
        }

        public Func<Despesa, Result<Despesa>> GravarRegistro { get; set; }

        public Despesa Despesa
        {
            get
            {
                return despesa;
            }
            set
            {
                despesa = value;

                txtNumero.Text = despesa.Id.ToString();
                txtDescricao.Text = despesa.Descricao;
                txtValor.Text = despesa.Valor.ToString();
                txtData.Value = despesa.Data;
                cmbFormaPgto.SelectedItem = despesa.FormaPagamento;

                int i = 0;

                for (int j = 0; j < listCategorias.Items.Count; j++)
                {
                    var categoria = (Categoria)listCategorias.Items[j];
                    if (despesa.Categorias.Contains(categoria))
                        listCategorias.SetItemChecked(i, true);

                    i++;
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            despesa.Descricao = txtDescricao.Text;
            despesa.Valor = Convert.ToDecimal(txtValor.Text);
            despesa.Data = txtData.Value;
            despesa.FormaPagamento = (FormaPgtoDespesaEnum)cmbFormaPgto.SelectedItem;

            var categoriasMarcadas = CategoriasMarcadas;

            foreach (var item in categoriasMarcadas)
                despesa.AtribuirCategoria(item);

            var categoriasDesmarcadas = CategoriasDesmarcadas;

            foreach (var item in categoriasDesmarcadas)
                despesa.RemoverCategoria(item);

            var resultadoValidacao = GravarRegistro(despesa);

            if (resultadoValidacao.IsFailed)
            {
                string primeiroErro = resultadoValidacao.Errors[0].Message;

                TelaPrincipalForm.Instancia.AtualizarRodape(primeiroErro);

                DialogResult = DialogResult.None;
            }
        }

        public List<Categoria> CategoriasMarcadas
        {
            get
            {
                return listCategorias.CheckedItems
                    .Cast<Categoria>()
                    .ToList();
            }
        }

        public List<Categoria> CategoriasDesmarcadas
        {
            get
            {
                return listCategorias.Items
                    .Cast<Categoria>()
                    .Except(CategoriasMarcadas)
                    .ToList();
            }
        }

        private void CarregarCategorias(List<Categoria> categorias)
        {
            foreach (var item in categorias)
            {
                listCategorias.Items.Add(item);
            }
        }

        private void CarregarFormaPgto()
        {
            var formas = Enum.GetValues(typeof(FormaPgtoDespesaEnum));

            foreach (var item in formas)
            {
                cmbFormaPgto.Items.Add(item);
            }
        }

    }
}
