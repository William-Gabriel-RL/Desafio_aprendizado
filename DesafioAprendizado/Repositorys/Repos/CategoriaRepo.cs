﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.CategoriaDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class CategoriaRepo : ICategoriaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public CategoriaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarCategoria(Categoria Categoria)
        {
            _context.Categorias.Update(Categoria);
            _context.SaveChanges();
        }

        public void CriarCategoria(Categoria Categoria)
        {
            _context.Categorias.Add(Categoria);
            _context.SaveChanges();
        }

        public void DeletarCategoria(int categoriaId)
        {
            Categoria? categoria = _context.Categorias.Find(categoriaId);
            if (categoria != null)
            {
                if (categoria.CategoriaDeletado != true)
                {
                    categoria.CategoriaDeletado = true;
                    categoria.CategoriaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(categoria);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Categoria já deletada");
                }
            }
            else
            {
                throw new Exception("Categoria não encontrada");
            }
        }

        public async Task<IEnumerable<ExibirCategoriaDTO>> ObterCategorias(int? categoriaId)
        {
            var categorias = _context.Categorias.Where(x => x.CategoriaDeletado == false);
            if (categoriaId != null)
                categorias = categorias.Where(x => x.CategoriaId == categoriaId);

            return await categorias.Select(x => new ExibirCategoriaDTO
            {
                CategoriaId = x.CategoriaId,
                CategoriaNome = x.CategoriaNome,
                CategoriaDataUltimaAtualizacao = x.CategoriaDataUltimaAtualizacao
            }).ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
