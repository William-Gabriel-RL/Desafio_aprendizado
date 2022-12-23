using BusinessLayer.DTO.PagamentoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoService _pagamentoService;
        public PagamentoController()
        {
            _pagamentoService = new PagamentoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "Valor, FormaPagamentoId, ComandaId, UsuarioMatricula")] CriarPagamentoDTO criarPagamentoDTO)
        {
            _pagamentoService.CriarPagamento(criarPagamentoDTO);
            return Ok("Pagamento criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<Pagamento>> Get()
        {
            return Ok(_pagamentoService.ObterTodosPagamentos());
        }

        [HttpGet("id")]
        public ActionResult<Pagamento> Get(int pagamentoId)
        {
            return Ok(_pagamentoService.ObterPagamentoPorId(pagamentoId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "PagamentoId, PagamentoDataHora, Valor, FormaPagamentoId, ComandaId, UsuarioMatricula, PagamentoDeletado")]AtualizarPagamentoDTO atualizarPagamentoDTO)
        {
            _pagamentoService.AtualizarPagamento(atualizarPagamentoDTO);
            return Ok("Pagamento atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] int pagamentoId)
        {
            _pagamentoService.DeletarPagamento(pagamentoId);
            return Ok("Pagamento deletado com sucesso");
        }
    }
}
