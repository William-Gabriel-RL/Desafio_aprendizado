using BusinessLayer.DTO.PagamentoDTO;
using Entities.Models;
using Repositorys.DTO.PagamentoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IPagamentoService
    {
        public void CriarPagamento(CriarPagamentoDTO pagamento);
        public ExibirPagamentoDTO? ObterPagamentoPorId(int pagamentoId);
        public Task<IEnumerable<ExibirPagamentoDTO>> ObterTodosPagamentos();
        public void AtualizarPagamento(AtualizarPagamentoDTO pagamento);
        public void DeletarPagamento(int pagamentoId);
    }
}
