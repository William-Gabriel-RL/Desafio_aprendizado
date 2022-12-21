using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaSituacaoService
    {
        public void CriarProdutoComandaSituacao(CriarProdutoComandaDTO produtoComandaSituacao);
        public ProdutoComandaSituacao? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId);
        public Task<IEnumerable<ProdutoComandaSituacao>> ObterTodosProdutosComandaSituacao();
        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaDTO produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
    }
}
