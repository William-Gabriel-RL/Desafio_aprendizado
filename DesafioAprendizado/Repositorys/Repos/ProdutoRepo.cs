using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ProdutoRepo : IProdutoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ProdutoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarProduto(Produto produto)
        {
            _context.Update(produto);
            _context.SaveChanges();
        }

        public void CriarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void DeletarProduto(int produtoId)
        {
            Produto? produto = _context.Produtos.Find(produtoId);
            if (produto != null)
            {
                if(produto.ProdutoDeletado == false)
                {
                    produto.ProdutoDeletado = true;
                    produto.ProdutoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(produto);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produto já deletado");
                }
            }
            else
            {
                throw new Exception("Protudo não encontrado");
            }
        }

        public Produto? ObterProdutoPorId(int produtoId)
        {
            return _context.Produtos.Find(produtoId);
        }

        public async Task<IEnumerable<Produto>> ObterTodosProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
