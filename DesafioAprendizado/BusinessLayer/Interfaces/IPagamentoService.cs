using BusinessLayer.DTO.PagamentoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IPagamentoService
    {
        public void CriarPagamento(CriarPagamentoDTO pagamento);
        public Pagamento? ObterPagamentoPorId(int pagamentoId);
        public Task<IEnumerable<Pagamento>> ObterTodosPagamentos();
        public void AtualizarPagamento(AtualizarPagamentoDTO pagamento);
        public void DeletarPagamento(int pagamentoId);
    }
}
