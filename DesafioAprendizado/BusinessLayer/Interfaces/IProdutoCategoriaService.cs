using BusinessLayer.DTO.ProdutoCategoriaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoCategoriaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IProdutoCategoriaService
    {
        public void CriarProdutoCategoria(CriarProdutoCategoriaDTO criarProdutoCategoriaDTO);
        public Task<IEnumerable<ExibirProdutoCategoriaDTO>> ObterProdutosCategorias(int? produtoId, int? categoriaId);
        public void AtualizarProdutoCategoria(AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO);
        public void DeletarProdutoCategoria(int produtoCategoriaId);
    }
}
