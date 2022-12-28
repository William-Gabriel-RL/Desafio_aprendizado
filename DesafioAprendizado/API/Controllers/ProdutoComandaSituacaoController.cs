using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1, 2, 3")]
    public class ProdutoComandaSituacaoController : ControllerBase
    {
        private readonly IProdutoComandaSituacaoService _produtoComandaSituacaoService;
        public ProdutoComandaSituacaoController()
        {
            _produtoComandaSituacaoService = new ProdutoComandaSituacaoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "ProdutoComandaSituacaoMotivo, UsuarioMatricula, StatusSituacaoId, ProdutoComandaId")] CriarProdutoComandaSituacaoDTO criarProdutoComandaSituacaoDTO)
        {
            var matricula = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _produtoComandaSituacaoService.CriarProdutoComandaSituacao(criarProdutoComandaSituacaoDTO, matricula);
            return Ok("Situacao do produto da comanda criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirProdutoComandaSituacaoDTO>> Get(int? produtoComandaSituacaoId, string? usuarioMatricula, int? statusSituacaoId)
        {
            return Ok(_produtoComandaSituacaoService.ObterProdutosComandaSituacao(produtoComandaSituacaoId, usuarioMatricula, statusSituacaoId).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoComandaSituacaoMotivo, ProdutoComandaSituacaoDeletado, UsuarioMatricula, StatusSituacaoId, ProdutoComandaId")] AtualizarProdutoComandaSituacaoDTO atualizarProdutoComandaSituacaoDTO)
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
