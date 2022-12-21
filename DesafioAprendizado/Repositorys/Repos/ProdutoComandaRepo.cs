using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ProdutoComandaRepo : IProdutoComandaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ProdutoComandaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarProdutoComanda(ProdutoComanda produtoComanda)
        {
            _context.Update(produtoComanda);
            _context.SaveChanges();
        }

        public void CriarProdutoComanda(ProdutoComanda produtoComanda)
        {
            _context.ProdutosComandas.Add(produtoComanda);
            _context.SaveChanges();
        }

        public void DeletarProdutoComanda(int produtoComandaId)
        {
            ProdutoComanda? produtoComanda = _context.ProdutosComandas.Find(produtoComandaId);
            if(produtoComanda != null)
            {
                if(produtoComanda.ProdutoComandaDeletado == false)
                {
                    produtoComanda.ProdutoComandaDeletado = true;
                    produtoComanda.ProdutoComandaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(produtoComanda);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Produto da comanda já deletado");
                }
            }
            else
            {
                throw new Exception("Produto da comanda não encontrado");
            }
        }

        public ProdutoComanda? ObterProdutoComandaPorId(int produtoComandaId)
        {
            return _context.ProdutosComandas.Find(produtoComandaId);
        }

        public async Task<IEnumerable<ProdutoComanda>> ObterTodosProdutosPorComanda()
        {
            return await _context.ProdutosComandas.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
