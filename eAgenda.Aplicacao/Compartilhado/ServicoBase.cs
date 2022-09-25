using FluentResults;
using FluentValidation;
using Serilog;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Aplicacao
{
    public abstract class ServicoBase<TDominio, TValidador> where TValidador : AbstractValidator<TDominio>, new()
    {
        protected virtual Result Validar(TDominio obj)
        {
            var validador = new TValidador();

            var resultadoValidacao = validador.Validate(obj);

            var erros = new List<Error>();

            foreach (var validationFailure in resultadoValidacao.Errors)
            {
                Log.Logger.Warning(validationFailure.ErrorMessage);

                erros.Add(new Error(validationFailure.ErrorMessage));
            }

            if (erros.Any())
                return Result.Fail(erros);

            return Result.Ok();
        }
    }
}
