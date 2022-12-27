using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Context;
using Repositorys.DTO;
using Repositorys.Interfaces;
using Repositorys.Repos;

namespace BusinessLayer.Services
{
    public class ProdutoComandaSituacaoService : IProdutoComandaSituacaoService
    {
        private readonly IProdutoComandaSituacaoRepo _produtoComandaSituacaoRepo;
        public ProdutoComandaSituacaoService()
        {
            _produtoComandaSituacaoRepo = new ProdutoComandaSituacaoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaSituacaoDTO atualizarProdutoComandaSituacaoDTO)
        {
            ProdutoComandaSituacao produtoComandaSituacao = new()
            {
                ProdutoComandaSituacaoId = atualizarProdutoComandaSituacaoDTO.ProdutoComandaSituacaoId,
                ProdutoComandaSituacaoMotivo = atualizarProdutoComandaSituacaoDTO.ProdutoComandaSituacaoMotivo,
                ProdutoComandaSituacaoDeletado = atualizarProdutoComandaSituacaoDTO.ProdutoComandaSituacaoDeletado,
                UsuarioMatricula = atualizarProdutoComandaSituacaoDTO.UsuarioMatricula,
                StatusSituacaoId = atualizarProdutoComandaSituacaoDTO.StatusSituacaoId,
                ProdutoComandaId = atualizarProdutoComandaSituacaoDTO.ProdutoComandaId,
                ProdutoComandaSituacaoDataUltimaAtualizacao = DateTime.Now
            };
            _produtoComandaSituacaoRepo.AtualizarProdutoComandaSituacao(produtoComandaSituacao);
        }

        public void CriarProdutoComandaSituacao(CriarProdutoComandaSituacaoDTO criarProdutoComandaSituacaoDTO)
        {
            ProdutoComandaSituacao produtoComandaSituacao = new()
            {
                ProdutoComandaSituacaoMotivo = criarProdutoComandaSituacaoDTO.ProdutoComandaSituacaoMotivo,
                UsuarioMatricula = criarProdutoComandaSituacaoDTO.UsuarioMatricula,
                StatusSituacaoId = criarProdutoComandaSituacaoDTO.StatusSituacaoId,
                ProdutoComandaId = criarProdutoComandaSituacaoDTO.ProdutoComandaId
            };
            _produtoComandaSituacaoRepo.CriarProdutoComandaSituacao(produtoComandaSituacao);
        }

        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId)
        {
            _produtoComandaSituacaoRepo.DeletarProdutoComandaSituacao(produtoComandaSituacaoId);
        }

        public ExibirProdutoComandaSituacaoDTO? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId)
        {
            return _produtoComandaSituacaoRepo.ObterProdutoComandaSituacaoPorId(produtoComandaSituacaoId);
        }

        public async Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterTodosProdutosComandaSituacao()
        {
            return await _produtoComandaSituacaoRepo.ObterTodosProdutosComandaSituacao();
        }
    }
}
