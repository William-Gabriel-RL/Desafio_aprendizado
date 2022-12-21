using BusinessLayer.DTO.CategoriaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface ICategoriaService
    {
        public void CriarCategoria(CriarCategoriaDTO criarCategoriaDTO);
        public Categoria? ObterCategoriaPorId(int CategoriaId);
        public Task<IEnumerable<Categoria>> ObterTodasCategorias();
        public void AtualizarCategoria(AtualizarCategoriaDTO Categoria);
        public void DeletarCategoria(int CategoriaId);
    }
}
