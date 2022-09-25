using AutoMapper;
using eAgenda.Aplicacao.ModuloTarefa;
using eAgenda.Dominio.Compartilhado;
using eAgenda.Dominio.ModuloTarefa;
using eAgenda.Infra.Configs;
using eAgenda.Infra.Orm;
using eAgenda.Infra.Orm.ModuloTarefa;
using eAgenda.Webapi.AutoMapperConfig;
using eAgenda.Webapi.ViewModels;
using FluentResults;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eAgenda.Webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : eAgendaControllerBase
    {
        private readonly ServicoTarefa servicoTarefa;
        private IMapper mapeadorTarefas;

        public TarefasController(ServicoTarefa servicoTarefa, IMapper mapeadorTarefas)
        {
            this.servicoTarefa = servicoTarefa; 
            this.mapeadorTarefas = mapeadorTarefas;
        }

        [HttpGet]
        public ActionResult<List<ListarTarefaViewModel>> SelecionarTodos()
        {
            var tarefaResult = servicoTarefa.SelecionarTodos(StatusTarefaEnum.Todos);

            if (tarefaResult.IsFailed)
            {
                return InternalError(tarefaResult);
            }

            return Ok(
                new{
                    sucesso = true,
                    dados = mapeadorTarefas.Map<List<ListarTarefaViewModel>>(tarefaResult.Value),
                    total = tarefaResult.Value.Count
                });
        }

        [HttpGet("visualizar-completa/{id:guid}")]
        public ActionResult<VisualizarTarefaViewModel> SelecionarTarefaCompletaPorId(Guid id) // D6E3F379-E6CE-4F6F-8C95-08DA9A4935DF
        {
            var tarefaResult = servicoTarefa.SelecionarPorId(id);

            if (tarefaResult.IsFailed && RegistroNaoEncontrado(tarefaResult))
                return NotFound(tarefaResult);

            if (tarefaResult.IsFailed)
                return InternalError(tarefaResult);

            return Ok(
                new
                {
                    sucesso = true,
                    dados = mapeadorTarefas.Map<VisualizarTarefaViewModel>(tarefaResult.Value),
                });
        }

        [HttpPost]
        public ActionResult<FormsTarefaViewModel> Inserir(InserirTarefaViewModel tarefaVM) //databinding - modelbinder
        {
            var listaErros = ModelState.Values
                .SelectMany( x => x.Errors)
                .Select(x => x.ErrorMessage);

            if (listaErros.Any())
            {
                return BadRequest(new
                {
                    sucesso = false,
                    erros = listaErros.ToList()
                });
            }

            var tarefa = mapeadorTarefas.Map<Tarefa>(tarefaVM);

            var tarefaResult = servicoTarefa.Inserir(tarefa);

            if (tarefaResult.IsFailed)
            {
                return InternalError(tarefaResult);
            }

            return Ok(
                new
                {
                    sucesso = true,
                    dados = tarefaVM,
                });
        }

        [HttpPut("{id:guid}")]
        public ActionResult<FormsTarefaViewModel> Editar(Guid id, InserirTarefaViewModel tarefaVM)
        {
            var listaErros = ModelState.Values
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage);

            if (listaErros.Any())
            {
                return BadRequest(new
                {
                    sucesso = false,
                    erros = listaErros.ToList()
                });
            }

            var tarefaResult = servicoTarefa.SelecionarPorId(id);

            if (tarefaResult.IsFailed && RegistroNaoEncontrado(tarefaResult))
                return NotFound(tarefaResult);

            var tarefa = mapeadorTarefas.Map(tarefaVM, tarefaResult.Value);

            tarefaResult = servicoTarefa.Editar(tarefa);

            if (tarefaResult.IsFailed)
            {
                return InternalError(tarefaResult);
            }

            return Ok(
                new
                {
                    sucesso = true,
                    dados = tarefaVM,
                });
        }

        [HttpDelete("{id:guid}")]
        public ActionResult Excluir(Guid id)
        {
            var tarefaResult = servicoTarefa.Excluir(id);

            if (tarefaResult.IsFailed && RegistroNaoEncontrado<Tarefa>(tarefaResult))
                return NotFound(tarefaResult);

            if (tarefaResult.IsFailed)
                return InternalError<Tarefa>(tarefaResult);

            return NoContent();
        }
    }
}
