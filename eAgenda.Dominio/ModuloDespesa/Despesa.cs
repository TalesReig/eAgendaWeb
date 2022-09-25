using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.ModuloDespesa
{
    public class Despesa : EntidadeBase<Despesa>
    {
        public Despesa()
        {
            Data = DateTime.Now;
            Categorias = new List<Categoria>();
        }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }

        public DateTime Data { get; set; }

        public FormaPgtoDespesaEnum FormaPagamento { get; set; }

        public List<Categoria> Categorias { get; set; }

        public override void Atualizar(Despesa registro)
        {
            Descricao = registro.Descricao;
            Valor = registro.Valor;
            Data = registro.Data;
            FormaPagamento = registro.FormaPagamento;
            Categorias = registro.Categorias;
        }

        public override string ToString()
        {
            return $"{Descricao} feita no dia {Data.ToShortDateString()}";
        }

        public Despesa Clonar()
        {
            return MemberwiseClone() as Despesa;
        }

        public void AtribuirCategoria(Categoria categoria)
        {
            if (Categorias.Contains(categoria) == false)
            {
                Categorias.Add(categoria);
                categoria.RegistrarDespesa(this);
            }
        }

        public void RemoverCategoria(Categoria categoria)
        {
            if (Categorias.Contains(categoria))
            {
                Categorias.Remove(categoria);
            }
        }
    }
}
