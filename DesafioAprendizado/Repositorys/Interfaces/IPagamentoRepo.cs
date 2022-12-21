using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IPagamentoRepo
    {
        public void CriarPagamento(Pagamento pagamento);
        public Pagamento? ObterPagamentoPorId(int pagamentoId);
        public Task<IEnumerable<Pagamento>> ObterTodosPagamentos();
        public void AtualizarPagamento(Pagamento pagamento);
        public void DeletarPagamento(int pagamentoId);
        public void Salvar();
    }
}
