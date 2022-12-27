using Entities.Models;
using Repositorys.DTO.PagamentoDTO;

namespace Repositorys.Interfaces
{
    public interface IPagamentoRepo
    {
        public void CriarPagamento(Pagamento pagamento);
        public ExibirPagamentoDTO? ObterPagamentoPorId(int pagamentoId);
        public Task<IEnumerable<ExibirPagamentoDTO>> ObterTodosPagamentos();
        public void AtualizarPagamento(Pagamento pagamento);
        public void DeletarPagamento(int pagamentoId);
        public void Salvar();
    }
}
