using BusinessLayer.DTO.ProdutoDTO;
using Repositorys.DTO.ProdutoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoService
    {
        public void CriarProduto(CriarProdutoDTO produto, string matricula);
        public ExibirProdutoDTO? ObterProdutoPorId(int produtoId);
        public Task<IEnumerable<ExibirProdutoDTO>> ObterTodosProdutos();
        public void AtualizarProduto(AtualizarProdutoDTO produto);
        public void DeletarProduto(int produtoId);
    }
}
