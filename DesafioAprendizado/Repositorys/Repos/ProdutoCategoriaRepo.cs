using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.ProdutoCategoriaDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ProdutoCategoriaRepo : IProdutoCategoriaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ProdutoCategoriaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarProdutoCategoria(ProdutoCategoria produtoCategoria)
        {
            _context.Update(produtoCategoria);
            _context.SaveChanges();
        }

        public void CriarProdutoCategoria(ProdutoCategoria produtoCategoria)
        {
            _context.ProdutosCategorias.Add(produtoCategoria);
            _context.SaveChanges();
        }

        public void DeletarProdutoCategoria(int produtoCategoriaId)
        {
            ProdutoCategoria? produtoCategoria = _context.ProdutosCategorias.Find(produtoCategoriaId);
            if (produtoCategoria != null)
            {
                if (produtoCategoria.ProdutoCategoriaDeletado == false)
                {
                    produtoCategoria.ProdutoCategoriaDeletado = true;
                    produtoCategoria.ProdutoCategoriaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(produtoCategoria);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Categoria de produto já deletada");
                }
            }
            else
            {
                throw new Exception("Categoria de produto não encontrada");
            }
        }

        public async Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterProdutosCategorias(int? produtoId, int? categoriaId)
        {
            if(produtoId != null || categoriaId != null)
            {
                return await _context.ProdutosCategorias
                    .Where(x => x.ProdutoId == produtoId || x.CategoriaId == categoriaId)
                    .Where(x => x.ProdutoCategoriaDeletado == false)
                    .Select(x => new ExibirProdutoCategoriaDTO
                    {
                        ProdutoId = x.ProdutoId,
                        Produto = x.Produto.ProdutoNome,
                        CategoriaId = x.CategoriaId,
                        Categoria = x.Categoria.CategoriaNome,
                        ProdutoCategoriaDataUltimaAtualizacao = x.ProdutoCategoriaDataUltimaAtualizacao
                    })
                    .ToListAsync();
            }
            return await _context.ProdutosCategorias
                .Where(x => x.ProdutoCategoriaDeletado == false)
                .Select(x => new ExibirProdutoCategoriaDTO
                {
                    ProdutoId = x.ProdutoId,
                    Produto = x.Produto.ProdutoNome,
                    CategoriaId = x.CategoriaId,
                    Categoria = x.Categoria.CategoriaNome,
                    ProdutoCategoriaDataUltimaAtualizacao = x.ProdutoCategoriaDataUltimaAtualizacao
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
