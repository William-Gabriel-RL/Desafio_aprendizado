using Entities.Models;
using Repositorys.DTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaSituacaoRepo
    {
        public void CriarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public ExibirProdutoComandaSituacaoDTO? ObterProdutoComandaSituacaoPorId(int produtoComandaSituacaoId);
        public Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterTodosProdutosComandaSituacao();
        public void AtualizarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao);
        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId);
        public void Salvar();
    }
}
