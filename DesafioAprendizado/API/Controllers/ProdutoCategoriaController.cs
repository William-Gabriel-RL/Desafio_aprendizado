using BusinessLayer.DTO.ProdutoCategoriaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoCategoriaController : ControllerBase
    {
        private readonly IProdutoCategoriaService _produtoCategoriaService;
        public ProdutoCategoriaController()
        {
            _produtoCategoriaService = new ProdutoCategoriaService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "ProdutoId, CategoriaId")] CriarProdutoCategoriaDTO criarProdutoCategoriaDTO)
        {
            _produtoCategoriaService.CriarProdutoCategoria(criarProdutoCategoriaDTO);
            return Ok("Relação ProdutoCategoria criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirProdutoCategoriaDTO>> Get()
        {
            return Ok(_produtoCategoriaService.ObterTodosProdutosCategorias().Result);
        }

        [HttpGet("id")]
        public ActionResult<ExibirProdutoCategoriaDTO> Get(int categoriaId)
        {
            return Ok(_produtoCategoriaService.ObterProdutoCategoriaPorCategoria(categoriaId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoId, CategoriaId, ProdutoCategoriaDeletado")] AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO)
        {
            _produtoCategoriaService.AtualizarProdutoCategoria(atualizarProdutoCategoriaDTO);
            return Ok("Relação ProdutoCategoria atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int produtoCategoriaId)
        {
            _produtoCategoriaService.DeletarProdutoCategoria(produtoCategoriaId);
            return Ok("Relação ProdutoCategoria deletada com sucesso");
        }
    }
}
