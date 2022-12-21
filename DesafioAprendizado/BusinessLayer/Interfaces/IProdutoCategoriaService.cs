using BusinessLayer.DTO.ProdutoCategoriaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoCategoriaService
    {
        public void CriarProdutoCategoria(CriarProdutoCategoriaDTO criarProdutoCategoriaDTO);
        public ProdutoCategoria? ObterProdutoCategoriaPorId(int produtoCategoriaId);
        public Task<IEnumerable<ProdutoCategoria>> ObterTodosProdutosCategorias();
        public void AtualizarProdutoCategoria(AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
    }
}
