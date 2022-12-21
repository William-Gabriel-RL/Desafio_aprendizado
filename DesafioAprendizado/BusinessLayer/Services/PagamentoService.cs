using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.PagamentoDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepo _pagamentoRepo;
        public PagamentoService()
        {
            _pagamentoRepo = new PagamentoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarPagamento(AtualizarPagamentoDTO pagamento)
        {
            throw new NotImplementedException();
        }

        public void CriarPagamento(CriarPagamentoDTO pagamento)
        {
            throw new NotImplementedException();
        }

        public void DeletarPagamento(int pagamentoId)
        {
            throw new NotImplementedException();
        }

        public Pagamento? ObterPagamentoPorId(int pagamentoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pagamento>> ObterTodosPagamentos()
        {
            throw new NotImplementedException();
        }
    }
}
