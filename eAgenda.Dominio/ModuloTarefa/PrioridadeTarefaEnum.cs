using System.ComponentModel;

namespace eAgenda.Dominio.ModuloTarefa
{
    public enum PrioridadeTarefaEnum : int
    {
        [Description("Baixinha")]
        Baixa = 0,

        [Description("Normal")]
        Normal = 1,

        [Description("Altíssima")]
        Alta = 2
    }
}