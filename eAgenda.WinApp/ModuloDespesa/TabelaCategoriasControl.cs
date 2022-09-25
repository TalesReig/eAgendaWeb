using eAgenda.Dominio.ModuloDespesa;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloDespesa
{
    public partial class TabelaCategoriasControl : UserControl
    {
        public TabelaCategoriasControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
           {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição"}

           };

            return colunas;
        }

        internal void AtualizarRegistros(List<Categoria> categorias)
        {
            grid.Rows.Clear();

            foreach (var categoria in categorias)
            {
                grid.Rows.Add(categoria.Id, categoria.Titulo);
            }
        }

        internal Guid ObtemNumeroCategoriaSelecionada()
        {
            return grid.SelecionarNumero<Guid>();
        }
    }
}
