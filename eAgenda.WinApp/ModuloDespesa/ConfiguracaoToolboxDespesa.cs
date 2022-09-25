using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class ConfiguracaoToolboxDespesa : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Despesas";

        public override string TooltipInserir => "Inserir uma nova Despesa";

        public override string TooltipEditar => "Editar uma Despesa existente";

        public override string TooltipExcluir => "Excluir uma Despesa existente";
    }
}