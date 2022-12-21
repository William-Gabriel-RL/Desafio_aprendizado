using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class ProdutoComandaService : IProdutoComandaService
    {
        private readonly IProdutoComandaRepo _produtoComandaRepo;
        public ProdutoComandaService()
        {
            _produtoComandaRepo = new ProdutoComandaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoComanda(AtualizarProdutoComandaDTO produtoComanda)
        {
            throw new NotImplementedException();
        }

        public void CriarProdutoComanda(CriarProdutoComandaDTO produtoComanda)
        {
            throw new NotImplementedException();
        }

        public void DeletarProdutoComanda(int produtoComandaId)
        {
            throw new NotImplementedException();
        }

        public ProdutoComanda? ObterProdutoComandaPorId(int produtoComandaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoComanda>> ObterTodosProdutosPorComanda()
        {
            throw new NotImplementedException();
        }
    }
}
