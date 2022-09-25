using FluentResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eAgenda.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class eAgendaControllerBase : ControllerBase
    {

        protected ActionResult InternalError<T>(Result<T> registroResult)
        {
            return StatusCode(500,
                new
                {
                    sucesso = false,
                    erros = registroResult.Errors.Select(x => x.Message)
                });//StatusCode e o Ok são um exemplo de wrapper(encapsula o método)
        }

        protected ActionResult NotFound<T>(Result<T> registroResult)
        {
            return StatusCode(404, new
            {
                sucesso = false,
                erros = registroResult.Errors.Select(x => x.Message)
            });
        }

        protected static bool RegistroNaoEncontrado<T>(Result<T> registroResult)
        {
            return registroResult.Errors.Any(x => x.Message.Contains("não encontrada"));
        }

    }
}
