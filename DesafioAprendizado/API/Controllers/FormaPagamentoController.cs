using BusinessLayer.DTO.FormaPagamentoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.FormaPagamentoDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class FormaPagamentoController : ControllerBase
    {
        private readonly IFormaPagamentoService _formaPagamentoService;
        public FormaPagamentoController()
        {
            _formaPagamentoService = new FormaPagamentoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "FormaPagagamentoNome")] CriarFormaPagamentoDTO criarFormaPagamentoDTO)
        {
            _formaPagamentoService.CriarFormaPagamento(criarFormaPagamentoDTO);
            return Ok("Forma de pagamento criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirFormaPagamentoDTO>> Get(int? formaPagamentoId)
        {
            return Ok(_formaPagamentoService.ObterFormasPagamento(formaPagamentoId).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "FormaPagamentoId, FormaPagagamentoNome, FormaPagamentoDeletado")] AtualizarFormaPagamentoDTO atualizarFormaPagamentoDTO)
        {
            _formaPagamentoService.AtualizarFormaPagamento(atualizarFormaPagamentoDTO);
            return Ok("Forma de pagamento atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int formaPagamentoId)
        {
            _formaPagamentoService.DeletarFormaPagamento(formaPagamentoId);
            return Ok("Forma de pagamento deletada com sucesso");
        }
    }
}
