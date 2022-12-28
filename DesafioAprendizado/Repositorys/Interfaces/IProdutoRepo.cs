using Entities.Models;
using Repositorys.DTO.ProdutoDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoRepo
    {
        public void CriarProduto(Produto produto);
        public Task<IEnumerable<ExibirProdutoDTO>> ObterProdutos(int? produtoId, string? usuarioId);
        public void AtualizarProduto(Produto produto);
        public void DeletarProduto(int produtoId);
        public void Salvar();
    }
}
