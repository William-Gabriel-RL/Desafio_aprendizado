using BusinessLayer.DTO.CategoriaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController()
        {
            _categoriaService = new CategoriaService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "CategoriaNome")]CriarCategoriaDTO criarCategoriaDTO)
        {
            _categoriaService.CriarCategoria(criarCategoriaDTO);
            return Ok("Categoria criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<Categoria>> Get()
        {
            return Ok(_categoriaService.ObterTodasCategorias().Result);
        }

        [HttpGet("id")]
        public Categoria? Get([FromQuery]int categoriaId)
        {
            return _categoriaService.ObterCategoriaPorId(categoriaId);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "CategoriaId, CategoriaNome, CategoriaDeletado")]AtualizarCategoriaDTO atualizarCategoriaDTO)
        {
            _categoriaService.AtualizarCategoria(atualizarCategoriaDTO);
            return Ok("Categoria atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int categoriaId)
        {
            _categoriaService.DeletarCategoria(categoriaId);
            return Ok("Categoria deletada com sucesso");
        }
    }
}
