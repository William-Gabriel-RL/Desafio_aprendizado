using BusinessLayer.DTO.ProdutoComandaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.ProdutoComandaDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoComandaController : ControllerBase
    {
        private readonly IProdutoComandaService _produtoComandaService;
        public ProdutoComandaController()
        {
            _produtoComandaService = new ProdutoComandaService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "ProdutoComandaQuantidadeProdutos, ProdutoComandaPreco, ProdutoComandaObservacao, ProdutoId, ComandaId")] CriarProdutoComandaDTO criarProdutoComandaDTO)
        {
            _produtoComandaService.CriarProdutoComanda(criarProdutoComandaDTO);
            return Ok("Produto da comanda criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirProdutoComandaDTO>> Get()
        {
            return Ok(_produtoComandaService.ObterTodosProdutosPorComanda().Result);
        }

        [HttpGet("id")]
        public ActionResult<ExibirProdutoComandaDTO> Get(int produtoComandaId)
        {
            return Ok(_produtoComandaService.ObterProdutoComandaPorId(produtoComandaId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoComandaId, ProdutoComandaQuantidadeProdutos, ProdutoComandaPreco, ProdutoComandaObservacao, ProdutoId, ComandaId, ProdutoComandaDeletado")] AtualizarProdutoComandaDTO atualizarProdutoComandaDTO)
        {
            _produtoComandaService.AtualizarProdutoComanda(atualizarProdutoComandaDTO);
            return Ok("Produto da comanda atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int produtoComandaId)
        {
            _produtoComandaService.DeletarProdutoComanda(produtoComandaId);
            return Ok("Produto da comanda deletado com sucesso");
        }
    }
}
