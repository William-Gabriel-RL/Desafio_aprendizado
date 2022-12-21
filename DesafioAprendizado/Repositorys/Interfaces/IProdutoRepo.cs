using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IProdutoRepo
    {
        public void CriarProduto(Produto produto);
        public Produto? ObterProdutoPorId(int produtoId);
        public Task<IEnumerable<Produto>> ObterTodosProdutos();
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int produtoId);
        public void Salvar();
    }
}
