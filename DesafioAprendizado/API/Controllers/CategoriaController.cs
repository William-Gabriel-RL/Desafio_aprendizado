using BusinessLayer.DTO.CategoriaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.CategoriaDTO;
using System.Data;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
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
        public ActionResult<ICollection<ExibirCategoriaDTO>> Get([FromQuery] int? categoriaId)
        {
            return Ok(_categoriaService.ObterCategorias(categoriaId).Result);
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
