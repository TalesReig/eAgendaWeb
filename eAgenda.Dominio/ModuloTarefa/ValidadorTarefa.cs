using FluentValidation;
using System;

namespace eAgenda.Dominio.ModuloTarefa
{
    public class ValidadorTarefa : AbstractValidator<Tarefa>
    {
        public ValidadorTarefa()
        {
            RuleFor(x => x.Titulo)
                .NotNull().WithMessage("O campo título é obrigatório")
                .NotEmpty().WithMessage("O campo título é obrigatório");

            RuleFor(x => x.DataCriacao)
                .NotEqual(DateTime.MinValue)
                .WithMessage("O campo Data de Criação é obrigatório");
        }
    }
}