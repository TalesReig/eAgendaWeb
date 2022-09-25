using FluentValidation;

namespace eAgenda.Dominio.ModuloDespesa
{
    public class ValidadorDespesa : AbstractValidator<Despesa>
    {
        public ValidadorDespesa()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.Valor)
                .NotNull()
                .NotEmpty()
                .GreaterThan(0);

            RuleFor(x => x.Data)
                .NotNull()
                .NotEmpty();

        }
    }
}
