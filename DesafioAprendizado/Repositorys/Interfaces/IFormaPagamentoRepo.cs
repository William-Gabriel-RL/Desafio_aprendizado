using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IFormaPagamentoRepo
    {
        public void CriarFormaPagamento(FormaPagamento formaPagamento);
        public FormaPagamento? ObterFormaPagamentoPorId(int formaPagamentoId);
        public Task<IEnumerable<FormaPagamento>> ObterTodasFormasPagamento();
        public void AtualizarFormaPagamento(FormaPagamento formaPagamento);
        public void DeletarFormaPagamento(int formaPagamentoId);
        public void Salvar();
    }
}
