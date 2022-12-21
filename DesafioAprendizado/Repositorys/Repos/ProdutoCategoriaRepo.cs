using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
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

        public ProdutoCategoria? ObterProdutoCategoriaPorId(int produtoCategoriaId)
        {
            return _context.ProdutosCategorias.Find(produtoCategoriaId);
        }

        public async Task<IEnumerable<ProdutoCategoria>> ObterTodosProdutosCategorias()
        {
            return await _context.ProdutosCategorias.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
