using BusinessLayer.DTO.ProdutoComandaSituacaoDTO;
using Repositorys.DTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaSituacaoService
    {
        public void CriarProdutoComandaSituacao(CriarProdutoComandaSituacaoDTO produtoComandaSituacao);
        public ExibirProdutoComandaSituacaoDTO? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId);
        public Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterTodosProdutosComandaSituacao();
        public void AtualizarProdutoComandaSituacao(AtualizarProdutoComandaSituacaoDTO produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
    }
}
