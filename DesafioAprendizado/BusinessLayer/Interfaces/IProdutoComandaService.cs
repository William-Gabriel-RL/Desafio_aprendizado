using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoComandaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoComandaService
    {
        public void CriarProdutoComanda(CriarProdutoComandaDTO produtoComanda);
        public Task<IEnumerable<ExibirProdutoComandaDTO>> ObterProdutoComanda(int? produtoComandaId, int? produtoId, string? comandaId);
        public void AtualizarProdutoComanda(AtualizarProdutoComandaDTO produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
    }
}
