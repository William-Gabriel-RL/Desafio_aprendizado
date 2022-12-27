using BusinessLayer.DTO.ProdutoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.ProdutoDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
            _produtoService.CriarProduto(criarProdutoDTO);
            return Ok("Produto criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirProdutoDTO>> Get()
        {
            return Ok(_produtoService.ObterTodosProdutos().Result);
        }

        [HttpGet("id")]
        public ActionResult<ExibirProdutoDTO> Get(int produtoId)
        {
            return Ok(_produtoService.ObterProdutoPorId(produtoId));
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
