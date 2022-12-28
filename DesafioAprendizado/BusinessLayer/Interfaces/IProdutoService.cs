using BusinessLayer.DTO.ProdutoDTO;
using Repositorys.DTO.ProdutoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoService
    {
        public void CriarProduto(CriarProdutoDTO produto, string matricula);
        public Task<IEnumerable<ExibirProdutoDTO>> ObterProdutos(int? produtoId, string? usuarioId);
        public void AtualizarProduto(AtualizarProdutoDTO produto);
        public void DeletarProduto(int produtoId);
    }
}
