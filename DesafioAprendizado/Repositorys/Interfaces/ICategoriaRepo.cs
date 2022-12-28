using Entities.Models;
using Repositorys.DTO.CategoriaDTO;

namespace Repositorys.Interfaces
{
    public interface ICategoriaRepo
    {
        public void CriarCategoria(Categoria Categoria);
        public Task<IEnumerable<ExibirCategoriaDTO>> ObterCategorias(int? CategoriaId);
        public void AtualizarCategoria(Categoria Categoria);
        public void DeletarCategoria(int CategoriaId);
        public void Salvar();
    }
}
