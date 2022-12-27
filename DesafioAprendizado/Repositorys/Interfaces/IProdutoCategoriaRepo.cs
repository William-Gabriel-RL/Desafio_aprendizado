using Entities.Models;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace Repositorys.Interfaces
{
    public interface IProdutoCategoriaRepo
    {
        public void CriarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public ExibirProdutoCategoriaDTO? ObterProdutoCategoriaPorCategoria(int categoriaId);
        public Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterTodosProdutosCategorias();
        public void AtualizarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
        public void Salvar();
    }
}
