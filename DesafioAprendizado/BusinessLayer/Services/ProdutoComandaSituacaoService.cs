using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class ProdutoComandaSituacaoService : IProdutoComandaSituacaoService
    {
        private readonly IProdutoComandaSituacaoRepo _produtoComandaSituacaoRepo;
        public ProdutoComandaSituacaoService()
        {
            _produtoComandaSituacaoRepo = new ProdutoComandaSituacaoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaDTO produtoComandaSituacao)
        {
            throw new NotImplementedException();
        }

        public void CriarProdutoComandaSituacao(CriarProdutoComandaDTO produtoComandaSituacao)
        {
            throw new NotImplementedException();
        }

        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId)
        {
            throw new NotImplementedException();
        }

        public ProdutoComandaSituacao? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoComandaSituacao>> ObterTodosProdutosComandaSituacao()
        {
            throw new NotImplementedException();
        }
    }
}
