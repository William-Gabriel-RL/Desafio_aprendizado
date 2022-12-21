using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaService
    {
        public void CriarProdutoComanda(CriarProdutoComandaDTO produtoComanda);
        public ProdutoComanda? ObterProdutoComandaPorId(int produtoComandaId);
        public Task<IEnumerable<ProdutoComanda>> ObterTodosProdutosPorComanda();
        public void AtualizarProdutoComanda(AtualizarProdutoComandaDTO produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
    }
}
