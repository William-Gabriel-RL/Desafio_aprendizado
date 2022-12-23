﻿using BusinessLayer.DTO.ProdutoCategoriaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Create([Bind(include: "ProdutoId, CategoriaId")]CriarProdutoCategoriaDTO criarProdutoCategoriaDTO)
        {
            _produtoCategoriaService.CriarProdutoCategoria(criarProdutoCategoriaDTO);
            return Ok("Relação ProdutoCategoria criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ProdutoCategoria>> Get()
        {
            return Ok(_produtoCategoriaService.ObterTodosProdutosCategorias().Result);
        }

        [HttpGet("id")]
        public ActionResult<ProdutoCategoria> Get(int produtoCategoriaId)
        {
            return Ok(_produtoCategoriaService.ObterProdutoCategoriaPorId(produtoCategoriaId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ProdutoId, CategoriaId, ProdutoCategoriaDeletado")]AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO)
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
