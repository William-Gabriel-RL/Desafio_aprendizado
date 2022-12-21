using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.CategoriaDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepo _categoriaRepo;
        public CategoriaService()
        {
            _categoriaRepo = new CategoriaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarCategoria(AtualizarCategoriaDTO Categoria)
        {
            throw new NotImplementedException();
        }

        public void CriarCategoria(CriarCategoriaDTO criarCategoriaDTO)
        {
            throw new NotImplementedException();
        }

        public void DeletarCategoria(int CategoriaId)
        {
            throw new NotImplementedException();
        }

        public Categoria? ObterCategoriaPorId(int CategoriaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> ObterTodasCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
