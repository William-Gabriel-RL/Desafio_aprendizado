using Entities.Models;
using Repositorys.DTO.ProdutoDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoRepo
    {
        public void CriarProduto(Produto produto);
        public ExibirProdutoDTO? ObterProdutoPorId(int produtoId);
        public Task<IEnumerable<ExibirProdutoDTO>> ObterTodosProdutos();
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int produtoId);
        public void Salvar();
    }
}
