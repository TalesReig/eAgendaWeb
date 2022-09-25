using eAgenda.Dominio.ModuloCompromisso;
using System;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromissosForm : Form
    {
        public TelaFiltroCompromissosForm()
        {
            InitializeComponent();
        }

        public StatusCompromissoEnum StatusSelecionado
        {
            get
            {
                if (rdbCompromissosPassados.Checked)
                    return StatusCompromissoEnum.Passados;

                else if (rdbCompromissosFuturos.Checked)
                    return StatusCompromissoEnum.Futuros;

                else
                    return StatusCompromissoEnum.Todos;
            }
        }

        public DateTime DataInicial => txtDataInicial.Value;

        public DateTime DataFinal => txtDataFinal.Value;

        private void rdbTodosCompromissos_CheckedChanged(object sender, EventArgs e)
        {
            groupCompromissoFuturos.Enabled = false;
        }

        private void rdbCompromissosPassados_CheckedChanged(object sender, EventArgs e)
        {
            groupCompromissoFuturos.Enabled = false;
        }

        private void rdbCompromissosFuturos_CheckedChanged(object sender, EventArgs e)
        {
            groupCompromissoFuturos.Enabled = true;
        }
    }
}
