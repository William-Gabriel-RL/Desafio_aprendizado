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

        public void AtualizarCategoria(AtualizarCategoriaDTO atualizarCategoriaDTO)
        {
            Categoria categoria = new()
            {
                CategoriaId = atualizarCategoriaDTO.CategoriaId,
                CategoriaNome = atualizarCategoriaDTO.CategoriaNome,
                CategoriaDeletado = atualizarCategoriaDTO.CategoriaDeletado,
                CategoriaDataUltimaAtualizacao = DateTime.Now,
            };
            _categoriaRepo.AtualizarCategoria(categoria);
        }

        public void CriarCategoria(CriarCategoriaDTO criarCategoriaDTO)
        {
            Categoria categoria = new()
            {
                CategoriaNome = criarCategoriaDTO.CategoriaNome,
                CategoriaDataUltimaAtualizacao = DateTime.Now
            };
            _categoriaRepo.CriarCategoria(categoria);
        }

        public void DeletarCategoria(int CategoriaId)
        {
            _categoriaRepo.DeletarCategoria(CategoriaId);
        }

        public Categoria? ObterCategoriaPorId(int CategoriaId)
        {
            return _categoriaRepo.ObterCategoriaPorId(CategoriaId);
        }

        public Task<IEnumerable<Categoria>> ObterTodasCategorias()
        {
            return _categoriaRepo.ObterTodasCategorias();
        }
    }
}
