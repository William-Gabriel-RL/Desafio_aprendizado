using Entities.Models;
using Repositorys.DTO.ProdutoComandaDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoComandaRepo
    {
        public void CriarProdutoComanda(ProdutoComanda produtoComanda);
        public Task<IEnumerable<ExibirProdutoComandaDTO>> ObterProdutoComanda(int? produtoComandaId, int? produtoId, string? comandaId);
        public void AtualizarProdutoComanda(ProdutoComanda produtoComanda);
        public void DeletarProdutoComanda(int produtoComandaId);
        public void Salvar();
    }
}
