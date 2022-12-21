using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface ICategoriaRepo
    {
        public void CriarCategoria(Categoria Categoria);
        public Categoria? ObterCategoriaPorId(int CategoriaId);
        public Task<IEnumerable<Categoria>> ObterTodasCategorias();
        public void AtualizarCategoria(Categoria Categoria);
        public void DeletarCategoria(int CategoriaId);
        public void Salvar();
    }
}
