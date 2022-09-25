using eAgenda.Dominio.ModuloTarefa;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloTarefa
{
    public partial class TelaFiltroTarefaForm : Form
    {
        public TelaFiltroTarefaForm()
        {
            InitializeComponent();
        }

        public StatusTarefaEnum StatusSelecionado
        {
            get
            {
                if (rdbTarefasConcluidas.Checked)
                    return StatusTarefaEnum.Concluidas;

                else if (rdbTarefasPendentes.Checked)
                    return StatusTarefaEnum.Pendentes;

                else
                    return StatusTarefaEnum.Todos;
            }
        }
    }
}
