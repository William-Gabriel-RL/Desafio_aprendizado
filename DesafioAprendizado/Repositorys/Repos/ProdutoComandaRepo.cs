using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.ProdutoComandaDTO;
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
            produtoComanda.ProdutoComandaPreco = _context.Produtos.Find(produtoComanda.ProdutoId).Preco * Convert.ToDecimal(produtoComanda.ProdutoComandaQuantidadeProdutos);
            _context.ProdutosComandas.Add(produtoComanda);
            _context.SaveChanges();
        }

        public void DeletarProdutoComanda(int produtoComandaId)
        {
            ProdutoComanda? produtoComanda = _context.ProdutosComandas.Find(produtoComandaId);
            if (produtoComanda != null)
            {
                if (produtoComanda.ProdutoComandaDeletado == false)
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

        public ExibirProdutoComandaDTO? ObterProdutoComandaPorId(int produtoComandaId)
        {
            return _context.ProdutosComandas
                .Where(x => x.ProdutoComandaId == produtoComandaId)
                .Select(x => new ExibirProdutoComandaDTO
                {
                    ProdutoComandaId = x.ProdutoComandaId,
                    ProdutoComandaQuantidadeProdutos = x.ProdutoComandaQuantidadeProdutos,
                    ProdutoComandaPreco = x.ProdutoComandaPreco,
                    ProdutoComandaObservacao = x.ProdutoComandaObservacao,
                    ProdutoId = x.ProdutoId,
                    ProdutoNome = x.Produto.ProdutoNome,
                    ComandaId = x.ComandaId,
                    Situacoes = x.Situacoes
                    .Where(x => x.ProdutoComandaSituacaoDeletado == false)
                    .Select(x => new ExibirProdutoComandaSituacaoStatus
                    {
                        ProdutoComandaSituacaoId = x.ProdutoComandaSituacaoId,
                        StatusSituacaoId = x.StatusSituacaoId,
                        StatusSituacaoNome = x.StatusSituacao.StatusSituacaoNome,
                        ProdutoComandaSituacaoDataHora = x.ProdutoComandaSituacaoDataHora,
                        ProdutoComandaSituacaoMotivo = x.ProdutoComandaSituacaoMotivo,
                        UsuarioMatricula = x.UsuarioMatricula,
                        UsuarioNome = x.Usuario.UsuarioNome,
                        UsuarioTipo = x.Usuario.Tipo.UsuarioTipoNome,
                        ProdutoComandaSituacaoDataUltimaAtualizacao = x.ProdutoComandaSituacaoDataHora,
                    }),
                    ProdutoComandaDataUltimaAtualizacao = x.ProdutoComandaDataUltimaAtualizacao
                })
                .FirstOrDefault();
        }

        public async Task<IEnumerable<ExibirProdutoComandaDTO>> ObterTodosProdutosPorComanda()
        {
            return await _context.ProdutosComandas
                .Select(x => new ExibirProdutoComandaDTO
                {
                    ProdutoComandaId = x.ProdutoComandaId,
                    ProdutoComandaQuantidadeProdutos = x.ProdutoComandaQuantidadeProdutos,
                    ProdutoComandaPreco = x.ProdutoComandaPreco,
                    ProdutoComandaObservacao = x.ProdutoComandaObservacao,
                    ProdutoId = x.ProdutoId,
                    ProdutoNome = x.Produto.ProdutoNome,
                    ComandaId = x.ComandaId,
                    Situacoes = x.Situacoes
                    .Where(x => x.ProdutoComandaSituacaoDeletado == false)
                    .Select(x => new ExibirProdutoComandaSituacaoStatus
                    {
                        ProdutoComandaSituacaoId = x.ProdutoComandaSituacaoId,
                        ProdutoComandaSituacaoDataHora = x.ProdutoComandaSituacaoDataHora,
                        ProdutoComandaSituacaoMotivo = x.ProdutoComandaSituacaoMotivo,
                        UsuarioMatricula = x.UsuarioMatricula,
                        UsuarioNome = x.Usuario.UsuarioNome,
                        UsuarioTipo = x.Usuario.Tipo.UsuarioTipoNome,
                        StatusSituacaoId = x.StatusSituacaoId,
                        StatusSituacaoNome = x.StatusSituacao.StatusSituacaoNome,
                        ProdutoComandaSituacaoDataUltimaAtualizacao = x.ProdutoComandaSituacaoDataHora
                    }),
                    ProdutoComandaDataUltimaAtualizacao = x.ProdutoComandaDataUltimaAtualizacao
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
