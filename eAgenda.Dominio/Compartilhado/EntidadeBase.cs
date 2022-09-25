using System;
using Taikandi;

namespace eAgenda.Dominio.Compartilhado
{
    public abstract class EntidadeBase<T>
    {
        public Guid Id { get; set; }

        //public IdentityUser<Guid> Usuario { get; set; }

        //public Guid UsuarioId { get; set; }

        public EntidadeBase()
        {
            Id = SequentialGuid.NewGuid();
        }

        public abstract void Atualizar(T registro);

    }
}
