using BusinessLayer.DTO.ProdutoCategoriaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoCategoriaService
    {
        public void CriarProdutoCategoria(CriarProdutoCategoriaDTO criarProdutoCategoriaDTO);
        public ExibirProdutoCategoriaDTO? ObterProdutoCategoriaPorCategoria(int categoriaId);
        public Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterTodosProdutosCategorias();
        public void AtualizarProdutoCategoria(AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
    }
}
