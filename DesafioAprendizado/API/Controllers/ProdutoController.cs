using BusinessLayer.DTO.ProdutoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.ProdutoDTO;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;
        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "ProdutoNome, ProdutoDescricao, Preco, CategoriaId, ProdutoFotoId, UsuarioId")] CriarProdutoDTO criarProdutoDTO)
        {
            var matricula = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _produtoService.CriarProduto(criarProdutoDTO, matricula);
            return Ok("Produto criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirProdutoDTO>> Get(int? produtoId, string? usuarioId)
        {
            return Ok(_produtoService.ObterProdutos(produtoId, usuarioId).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoId, ProdutoNome, ProdutoDescricao, Preco, CategoriaId, ProdutoFotoId, UsuarioId, ProdutoDeletado")] AtualizarProdutoDTO atualizarProdutoDTO)
        {
            _produtoService.AtualizarProduto(atualizarProdutoDTO);
            return Ok("Produto atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int produtoId)
        {
            _produtoService.DeletarProduto(produtoId);
            return Ok("Produto deletado com sucesso");
        }
    }
}
