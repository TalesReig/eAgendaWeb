using eAgenda.Dominio.Compartilhado;
using System;

namespace eAgenda.Dominio.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public Contato()
        {
        }

        public Contato(string n, string e, string t, string emp, string c)
        {
            Nome = n;
            Email = e;
            Telefone = t;
            Empresa = emp;
            Cargo = c;
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public override void Atualizar(Contato registro)
        {
            Id = registro.Id;
            Nome = registro.Nome;
            Email = registro.Email;
            Telefone = registro.Telefone;
            Empresa = registro.Empresa;
            Cargo = registro.Cargo;
        }

        public override bool Equals(object obj)
        {
            return obj is Contato contato &&
                   Id == contato.Id &&
                   Nome == contato.Nome &&
                   Email == contato.Email &&
                   Telefone == contato.Telefone &&
                   Empresa == contato.Empresa &&
                   Cargo == contato.Cargo;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome, Email, Telefone, Empresa, Cargo);
        }

        public override string ToString()
        {
            return Nome + " - " + Email;
        }

        public Contato Clonar()
        {
            return MemberwiseClone() as Contato;
        }
    }
}
