using Entities.Models;
using Repositorys.DTO.CategoriaDTO;

namespace Repositorys.Interfaces
{
    public interface ICategoriaRepo
    {
        public void CriarCategoria(Categoria Categoria);
        public ExibirCategoriaDTO? ObterCategoriaPorId(int CategoriaId);
        public Task<IEnumerable<ExibirCategoriaDTO>> ObterTodasCategorias();
        public void AtualizarCategoria(Categoria Categoria);
        public void DeletarCategoria(int CategoriaId);
        public void Salvar();
    }
}
