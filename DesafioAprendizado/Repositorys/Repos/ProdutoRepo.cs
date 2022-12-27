using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.ProdutoDTO;
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
                if (produto.ProdutoDeletado == false)
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

        public ExibirProdutoDTO? ObterProdutoPorId(int produtoId)
        {
            return _context.Produtos
                .Where(x => x.ProdutoId == produtoId)
                .Select(x => new ExibirProdutoDTO
                {
                    ProdutoId = x.ProdutoId,
                    ProdutoNome = x.ProdutoNome,
                    ProdutoDescricao = x.ProdutoDescricao,
                    Preco = x.Preco,
                    ProdutoDeletado = x.ProdutoDeletado,
                    ProdutoFotoId = x.ProdutoFotoId,
                    ProdutoDataUltimaAtualizacao = x.ProdutoDataUltimaAtualizacao,
                    UsuarioId = x.UsuarioId,
                    Categorias = x.Categorias
                    .Select(x => new ProdutoExibirCategoriaDTO
                    {
                        CategoriaNome = x.Categoria.CategoriaNome
                    })
                })
                .FirstOrDefault();
        }

        public async Task<IEnumerable<ExibirProdutoDTO>> ObterTodosProdutos()
        {
            return await _context.Produtos
                .Select(x => new ExibirProdutoDTO
                {
                    ProdutoId = x.ProdutoId,
                    ProdutoNome = x.ProdutoNome,
                    ProdutoDescricao = x.ProdutoDescricao,
                    Preco = x.Preco,
                    ProdutoDeletado = x.ProdutoDeletado,
                    ProdutoFotoId = x.ProdutoFotoId,
                    ProdutoDataUltimaAtualizacao = x.ProdutoDataUltimaAtualizacao,
                    UsuarioId = x.UsuarioId,
                    Categorias = (ICollection<ProdutoExibirCategoriaDTO>)x.Categorias.Select(x => new ProdutoExibirCategoriaDTO
                    {
                        CategoriaNome = x.Categoria.CategoriaNome
                    })
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
