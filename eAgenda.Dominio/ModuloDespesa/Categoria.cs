using eAgenda.Dominio.Compartilhado;
using System;
using System.Collections.Generic;

namespace eAgenda.Dominio.ModuloDespesa
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public Categoria()
        {
            Despesas = new List<Despesa>();
        }

        public string Titulo { get; set; }

        public List<Despesa> Despesas { get; set; }

        public override void Atualizar(Categoria registro)
        {
            Titulo = registro.Titulo;
        }

        public override string ToString()
        {
            return Titulo;
        }

        public override bool Equals(object obj)
        {
            return obj is Categoria despesa &&
                   Id == despesa.Id &&
                   Titulo == despesa.Titulo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo);
        }

        public Categoria Clonar()
        {
            return MemberwiseClone() as Categoria;
        }

        public void RegistrarDespesa(Despesa despesa)
        {
            if (Despesas.Contains(despesa) == false)
            {
                Despesas.Add(despesa);
                despesa.AtribuirCategoria(this);
            }
        }
    }
}