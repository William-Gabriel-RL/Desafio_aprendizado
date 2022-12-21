using BusinessLayer.DTO.ProdutoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoService
    {
        public void CriarProduto(CriarProdutoDTO produto);
        public Produto? ObterProdutoPorId(int produtoId);
        public Task<IEnumerable<Produto>> ObterTodosProdutos();
        public void AtualizarProduto(AtualizarProdutoDTO produto);
        public void DeletarProduto(int produtoId);
    }
}
