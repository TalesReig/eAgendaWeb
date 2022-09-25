using eAgenda.WinApp.Compartilhado;

namespace eAgenda.WinApp.ModuloTarefa
{
    public class ConfiguracaoToolboxTarefa : ConfiguracaoToolboxBase
    {
        public override string TipoCadastro => "Controle de Tarefas";

        public override string TooltipInserir { get { return "Inserir uma nova tarefa"; } }

        public override string TooltipEditar { get { return "Editar uma tarefa existente"; } }

        public override string TooltipExcluir { get { return "Excluir uma tarefa existente"; } }

        public override string TooltipFiltrar { get { return "Filtrar Tarefas por Status"; } }

        public override string TooltipAtualizarItens => "Atualizar itens da tarefa";

        public override bool AtualizarItensHabilitado => true;

        public override bool FiltrarHabilitado => true;
    }
}
