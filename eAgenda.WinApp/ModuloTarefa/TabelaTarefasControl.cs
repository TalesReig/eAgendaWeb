using eAgenda.Dominio.ModuloTarefa;
using eAgenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefasControl : UserControl
    {
        public TabelaTarefasControl()
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

                new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título"},

                new DataGridViewTextBoxColumn { DataPropertyName = "Prioridade", HeaderText = "Prioridade"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataCriacao", HeaderText = "Criada em"},

                new DataGridViewTextBoxColumn { DataPropertyName = "DataConclusao", HeaderText = "Concluída em"},

                new DataGridViewTextBoxColumn { DataPropertyName = "PercentualConcluido", HeaderText = "% Concluído"},
            };

            return colunas;
        }

        public Guid ObtemNumeroTarefaSelecionado()
        {
            return grid.SelecionarNumero<Guid>();
        }

        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            grid.Rows.Clear();

            foreach (Tarefa tarefa in tarefas)
            {
                grid.Rows.Add(tarefa.Id, tarefa.Titulo, tarefa.Prioridade,
                    tarefa.DataCriacao, tarefa.DataConclusao, tarefa.PercentualConcluido);
            }
        }


    }
}
