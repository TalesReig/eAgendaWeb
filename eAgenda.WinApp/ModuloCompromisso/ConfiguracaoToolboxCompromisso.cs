using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloCompromisso
{
    public class ConfiguracaoToolboxCompromisso : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Compromissos";

        public override string TooltipInserir => "Inserir um novo compromisso";

        public override string TooltipEditar => "Editar um compromisso existente";

        public override string TooltipExcluir => "Excluir um compromisso existente";

        public override string TooltipFiltrar { get { return "Filtrar Compromisso por Status"; } }

        public override bool FiltrarHabilitado => true;
    }
}
