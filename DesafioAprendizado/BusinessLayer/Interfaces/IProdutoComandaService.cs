using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoComandaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaService
    {
        public void CriarProdutoComanda(CriarProdutoComandaDTO produtoComanda);
        public ExibirProdutoComandaDTO? ObterProdutoComandaPorId(int produtoComandaId);
        public Task<IEnumerable<ExibirProdutoComandaDTO>> ObterTodosProdutosPorComanda();
        public void AtualizarProdutoComanda(AtualizarProdutoComandaDTO produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
    }
}
