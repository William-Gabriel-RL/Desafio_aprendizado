using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO;
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
            if (produtoComandaSituacao != null)
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

        public ExibirProdutoComandaSituacaoDTO? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId)
        {
            return _context.ProdutosComandasSituacoes
                .Select(x => new ExibirProdutoComandaSituacaoDTO
                {
                    ProdutoComandaSituacaoId = x.ProdutoComandaSituacaoId,
                    ProdutoComandaSituacaoDataHora = x.ProdutoComandaSituacaoDataHora,
                    ProdutoComandaSituacaoMotivo = x.ProdutoComandaSituacaoMotivo,
                    ProdutoComandaSituacaoDeletado = x.ProdutoComandaSituacaoDeletado,
                    ProdutoComandaSituacaoDataUltimaAtualizacao = x.ProdutoComandaSituacaoDataUltimaAtualizacao,
                    UsuarioMatricula = x.UsuarioMatricula,
                    UsuarioNome = x.Usuario.UsuarioNome,
                    UsuarioTipo = x.Usuario.Tipo.UsuarioTipoNome,
                    StatusSituacaoId = x.StatusSituacaoId,
                    StatusSituacaoNome = x.StatusSituacao.StatusSituacaoNome,
                    ProdutoComandaId = x.ProdutoComandaId
                })
                .FirstOrDefault(x => x.ProdutoComandaSituacaoId == produtoComandaSituacaoId);
        }

        public async Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterTodosProdutosComandaSituacao()
        {
            return await _context.ProdutosComandasSituacoes
                .Select(x => new ExibirProdutoComandaSituacaoDTO
                {
                    ProdutoComandaSituacaoId = x.ProdutoComandaSituacaoId,
                    ProdutoComandaSituacaoDataHora = x.ProdutoComandaSituacaoDataHora,
                    ProdutoComandaSituacaoMotivo = x.ProdutoComandaSituacaoMotivo,
                    ProdutoComandaSituacaoDeletado = x.ProdutoComandaSituacaoDeletado,
                    ProdutoComandaSituacaoDataUltimaAtualizacao = x.ProdutoComandaSituacaoDataUltimaAtualizacao,
                    UsuarioMatricula = x.UsuarioMatricula,
                    UsuarioNome = x.Usuario.UsuarioNome,
                    UsuarioTipo = x.Usuario.Tipo.UsuarioTipoNome,
                    StatusSituacaoId = x.StatusSituacaoId,
                    StatusSituacaoNome = x.StatusSituacao.StatusSituacaoNome,
                    ProdutoComandaId = x.ProdutoComandaId
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
