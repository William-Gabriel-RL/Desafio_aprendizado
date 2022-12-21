using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoCategoriaDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class ProdutoCategoriaService : IProdutoCategoriaService
    {
        private readonly IProdutoCategoriaRepo _produtoCategoriaRepo;
        public ProdutoCategoriaService()
        {
            _produtoCategoriaRepo = new ProdutoCategoriaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoCategoria(AtualizarProdutoCategoriaDTO atualizarProdutoCategoriaDTO)
        {
            throw new NotImplementedException();
        }

        public void CriarProdutoCategoria(CriarProdutoCategoriaDTO criarProdutoCategoriaDTO)
        {
            throw new NotImplementedException();
        }

        public void DeletarProdutoCategoria(int produtoCategoriaId)
        {
            throw new NotImplementedException();
        }

        public ProdutoCategoria? ObterProdutoCategoriaPorId(int produtoCategoriaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoCategoria>> ObterTodosProdutosCategorias()
        {
            throw new NotImplementedException();
        }
    }
}
