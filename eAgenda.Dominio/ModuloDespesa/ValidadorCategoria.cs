using FluentValidation;

namespace eAgenda.Dominio.ModuloDespesa
{
    public class ValidadorCategoria : AbstractValidator<Categoria>
    {
        public ValidadorCategoria()
        {
            RuleFor(x => x.Titulo)
                .NotNull()
                .NotEmpty();
        }
    }
}
