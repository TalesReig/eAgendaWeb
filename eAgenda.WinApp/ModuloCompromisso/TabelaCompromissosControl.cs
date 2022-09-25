using eAgenda.Dominio.ModuloCompromisso;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissosControl : UserControl
    {
        public TabelaCompromissosControl()
        {
            InitializeComponent();
            grid.ConfigurarGridZebrado();
            grid.ConfigurarGridSomenteLeitura();
            grid.Columns.AddRange(ObterColunas());
        }

        public DataGridViewColumn[] ObterColunas()
        {
            var colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Assunto", HeaderText = "Assunto"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data"},

                new DataGridViewTextBoxColumn { DataPropertyName = "HoraInicio", HeaderText = "Começa às"},

                new DataGridViewTextBoxColumn { DataPropertyName = "HoraTermino", HeaderText = "Termina às"},

                new DataGridViewTextBoxColumn {DataPropertyName = "Contato", HeaderText = "Contato"}
            };

            return colunas;
        }

        public Guid ObtemNumeroCompromissoSelecionado()
        {
            return grid.SelecionarNumero<Guid>();
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            grid.Rows.Clear();

            foreach (var compromisso in compromissos)
            {
                grid.Rows.Add(compromisso.Id, compromisso.Assunto,
                    compromisso.Data.ToShortDateString(), compromisso.HoraInicio, compromisso.HoraTermino,
                    compromisso.Contato?.Nome);
            }
        }

    }
}
