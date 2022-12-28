using BusinessLayer.DTO.PagamentoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.PagamentoDTO;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1, 2")]
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
            var matricula = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _pagamentoService.CriarPagamento(criarPagamentoDTO, matricula);
            return Ok("Pagamento criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirPagamentoDTO>> Get()
        {
            return Ok(_pagamentoService.ObterTodosPagamentos().Result);
        }

        [HttpGet("id")]
        public ActionResult<ExibirPagamentoDTO> Get(int pagamentoId)
        {
            return Ok(_pagamentoService.ObterPagamentoPorId(pagamentoId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "PagamentoId, PagamentoDataHora, Valor, FormaPagamentoId, ComandaId, UsuarioMatricula, PagamentoDeletado")] AtualizarPagamentoDTO atualizarPagamentoDTO)
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
