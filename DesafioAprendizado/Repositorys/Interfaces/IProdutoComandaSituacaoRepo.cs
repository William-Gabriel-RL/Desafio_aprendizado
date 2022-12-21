using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaSituacaoRepo
    {
        public void CriarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public ProdutoComandaSituacao? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId);
        public Task<IEnumerable<ProdutoComandaSituacao>> ObterTodosProdutosComandaSituacao();
        public void AtualizarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
        public void Salvar();
    }
}
