using Entities.Models;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoCategoriaRepo
    {
        public void CriarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterProdutosCategorias(int? produtoId, int? categoriaId);
        public void AtualizarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
        public void Salvar();
    }
}
