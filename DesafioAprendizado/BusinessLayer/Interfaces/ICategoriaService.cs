using BusinessLayer.DTO.CategoriaDTO;
using Entities.Models;
using Repositorys.DTO.CategoriaDTO;

namespace BusinessLayer.Interfaces
{
    public interface ICategoriaService
    {
        public void CriarCategoria(CriarCategoriaDTO criarCategoriaDTO);
        public Task<IEnumerable<ExibirCategoriaDTO>> ObterCategorias(int? categoriaId);
        public void AtualizarCategoria(AtualizarCategoriaDTO Categoria);
        public void DeletarCategoria(int CategoriaId);
    }
}
