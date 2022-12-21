using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaRepo
    {
        public void CriarProdutoComanda(ProdutoComanda produtoComanda);
        public ProdutoComanda? ObterProdutoComandaPorId(int produtoComandaId);
        public Task<IEnumerable<ProdutoComanda>> ObterTodosProdutosPorComanda();
        public void AtualizarProdutoComanda(ProdutoComanda produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
        public void Salvar();
    }
}
