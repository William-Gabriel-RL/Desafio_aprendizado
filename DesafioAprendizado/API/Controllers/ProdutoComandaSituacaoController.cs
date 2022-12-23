using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoComandaSituacaoController : ControllerBase
    {
        private readonly IProdutoComandaSituacaoService _produtoComandaSituacaoService;
        public ProdutoComandaSituacaoController()
        {
            _produtoComandaSituacaoService = new ProdutoComandaSituacaoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "ProdutoComandaSituacaoMotivo, UsuarioMatricula, StatusSituacaoId, ProdutoComandaId")]CriarProdutoComandaSituacaoDTO criarProdutoComandaSituacaoDTO)
        {
            _produtoComandaSituacaoService.CriarProdutoComandaSituacao(criarProdutoComandaSituacaoDTO);
            return Ok("Situacao do produto da comanda criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ProdutoComandaSituacao>> Get()
        {
            return Ok(_produtoComandaSituacaoService.ObterTodosProdutosComandaSituacao().Result);
        }

        [HttpGet("id")]
        public ActionResult<ProdutoComandaSituacao> Get(int produtoComandaSituacaoId)
        {
            return Ok(_produtoComandaSituacaoService.ObterProdutoComandaSituacaoPorId(produtoComandaSituacaoId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoComandaSituacaoMotivo, ProdutoComandaSituacaoDeletado, UsuarioMatricula, StatusSituacaoId, ProdutoComandaId")]AtualizarProdutoComandaSituacaoDTO atualizarProdutoComandaSituacaoDTO)
        {
            _produtoComandaSituacaoService.AtualizarProdutoComandaSituacao(atualizarProdutoComandaSituacaoDTO);
            return Ok("Situacao do produto da comanda atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int produtoComandaSituacaoId)
        {
            _produtoComandaSituacaoService.DeletarProdutoComandaSituacao(produtoComandaSituacaoId);
            return Ok("Situacao do produto da comanda deletada com sucesso");
        }
    }
}
