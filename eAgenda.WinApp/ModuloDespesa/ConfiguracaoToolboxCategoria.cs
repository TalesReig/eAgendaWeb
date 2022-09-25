using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloDespesa
{
    public class ConfiguracaoToolboxCategoria : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Categorias de Despesas";

        public override string TooltipInserir => "Inserir uma nova Categoria";

        public override string TooltipEditar => "Editar uma Categoria existente";

        public override string TooltipExcluir => "Excluir uma Categoria existente";

        public override string TooltipVisualizar => "Visulizar as Despesas da Categoria";

        public override bool VisualizarHabilitado => true;
    }
}
