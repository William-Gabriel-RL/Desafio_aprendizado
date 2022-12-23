using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaSituacaoService
    {
        public void CriarProdutoComandaSituacao(CriarProdutoComandaSituacaoDTO produtoComandaSituacao);
        public ProdutoComandaSituacao? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId);
        public Task<IEnumerable<ProdutoComandaSituacao>> ObterTodosProdutosComandaSituacao();
        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaSituacaoDTO produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
    }
}
