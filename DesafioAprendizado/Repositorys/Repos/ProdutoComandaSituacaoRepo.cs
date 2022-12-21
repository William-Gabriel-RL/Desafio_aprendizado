using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ProdutoComandaSituacaoRepo : IProdutoComandaSituacaoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ProdutoComandaSituacaoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao)
        {
            _context.Update(produtoComandaSituacao);
            _context.SaveChanges();
        }

        public void CriarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao)
        {
            _context.ProdutosComandasSituacoes.Add(produtoComandaSituacao);
            _context.SaveChanges();
        }

        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId)
        {
            ProdutoComandaSituacao? produtoComandaSituacao = _context.ProdutosComandasSituacoes.Find(produtoComandaSituacaoId);
            if(produtoComandaSituacao != null)
            {
                if (produtoComandaSituacao.ProdutoComandaSituacaoDeletado == false)
                {
                    produtoComandaSituacao.ProdutoComandaSituacaoDeletado = true;
                    produtoComandaSituacao.ProdutoComandaSituacaoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(produtoComandaSituacao);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Situação do produto da comanda já deletada");
                }
            }
            else
            {
                throw new Exception("Situação do produto da comanda não encontrada");
            }
        }

        public ProdutoComandaSituacao? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId)
        {
            return _context.ProdutosComandasSituacoes.Find(produtoComandaSituacaoId);
        }

        public async Task<IEnumerable<ProdutoComandaSituacao>> ObterTodosProdutosComandaSituacao()
        {
            return await _context.ProdutosComandasSituacoes.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
