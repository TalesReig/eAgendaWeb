using eAgenda.Dominio.ModuloContato;
using System.Windows.Forms;

namespace eAgenda.WinApp.ModuloContato
{
    public partial class TelaAgrupamentoContatoForm : Form
    {
        public TelaAgrupamentoContatoForm()
        {
            InitializeComponent();
        }

        public AgrupamentoContatoEnum TipoAgrupamento
        {
            get
            {
                if (rdbAgruparPorEmpresa.Checked)
                    return AgrupamentoContatoEnum.AgruparPorEmpresa;

                else if (rdbAgruparPorCargo.Checked)
                    return AgrupamentoContatoEnum.AgruparPorCargo;

                else
                    return AgrupamentoContatoEnum.NaoAgrupar;
            }

        }
    }
}
