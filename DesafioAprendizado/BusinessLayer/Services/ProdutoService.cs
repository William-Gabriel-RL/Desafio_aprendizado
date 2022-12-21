using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepo _produtoRepo;
        public ProdutoService()
        {
            _produtoRepo = new ProdutoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProduto(AtualizarProdutoDTO produto)
        {
            throw new NotImplementedException();
        }

        public void CriarProduto(CriarProdutoDTO produto)
        {
            throw new NotImplementedException();
        }

        public void DeletarProduto(int produtoId)
        {
            throw new NotImplementedException();
        }

        public Produto? ObterProdutoPorId(int produtoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterTodosProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
