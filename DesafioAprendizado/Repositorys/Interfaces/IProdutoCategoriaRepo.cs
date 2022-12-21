using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IProdutoCategoriaRepo
    {
        public void CriarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public ProdutoCategoria? ObterProdutoCategoriaPorId(int produtoCategoriaId);
        public Task<IEnumerable<ProdutoCategoria>> ObterTodosProdutosCategorias();
        public void AtualizarProdutoCategoria(ProdutoCategoria produtoCategoria);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
        public void Salvar();
    }
}
