using eAgenda.Dominio.ModuloContato;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{


    public partial class TabelaContatosControl : UserControl
    {

        Subro.Controls.DataGridViewGrouper agrupadorContatos;
        private AgrupamentoContatoEnum tipoAgrupamento;

        public TabelaContatosControl()
        {
            InitializeComponent();

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
            grid.Columns.AddRange(ObterColunas());

            tipoAgrupamento = AgrupamentoContatoEnum.NaoAgrupar;
        }

        private DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Empresa", HeaderText = "Empresa"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Cargo", HeaderText = "Cargo"}
            };

            return colunas;
        }

        public Guid ObtemNumeroContatoSelecionado()
        {
            return grid.SelecionarNumero<Guid>();
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            DesagruparContatos();

            grid.DataSource = contatos;

            agrupadorContatos = new Subro.Controls.DataGridViewGrouper(grid);

            AgruparContatos();
        }

        public void DesagruparContatos()
        {
            if (agrupadorContatos == null)
                return;

            var campos = new string[] { "Cargo", "Empresa" };

            agrupadorContatos.RemoveGrouping();
            grid.RowHeadersVisible = true;

            foreach (var campo in campos)
                foreach (DataGridViewColumn item in grid.Columns)
                    if (item.DataPropertyName == campo)
                        item.Visible = true;
        }

        public void AgruparContatos(AgrupamentoContatoEnum tipoAgrupamento)
        {
            this.tipoAgrupamento = tipoAgrupamento;

            AgruparContatos();
        }

        private void AgruparContatos()
        {
            switch (tipoAgrupamento)
            {
                case AgrupamentoContatoEnum.AgruparPorEmpresa:
                    AgruparContatosPor("Empresa");
                    break;

                case AgrupamentoContatoEnum.AgruparPorCargo:
                    AgruparContatosPor("Cargo");
                    break;

                case AgrupamentoContatoEnum.NaoAgrupar:
                    DesagruparContatos();
                    break;

                default:
                    break;
            }
        }

        private void AgruparContatosPor(string campo)
        {
            if (agrupadorContatos == null)
                return;

            agrupadorContatos.RemoveGrouping();
            agrupadorContatos.SetGroupOn(campo);
            agrupadorContatos.Options.ShowGroupName = false;
            agrupadorContatos.Options.GroupSortOrder = SortOrder.None;

            foreach (DataGridViewColumn item in grid.Columns)
                if (item.DataPropertyName == campo)
                    item.Visible = false;

            grid.RowHeadersVisible = false;
            grid.ClearSelection();
        }


    }
}
