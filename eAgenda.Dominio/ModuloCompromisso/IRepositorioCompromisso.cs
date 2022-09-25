using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorio<Compromisso>
    {
        List<Compromisso> SelecionarCompromissosFuturos(DateTime dataInicial, DateTime dataFinal);

        List<Compromisso> SelecionarCompromissosPassados(DateTime dataDeHoje);
    }
}
