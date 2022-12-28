using Entities.Models;
using Repositorys.DTO.FormaPagamentoDTO;

namespace Repositorys.Interfaces
{
    public interface IFormaPagamentoRepo
    {
        public void CriarFormaPagamento(FormaPagamento formaPagamento);
        public ExibirFormaPagamentoDTO? ObterFormaPagamentoPorId(int formaPagamentoId);
        public Task<IEnumerable<ExibirFormaPagamentoDTO>> ObterTodasFormasPagamento();
        public void AtualizarFormaPagamento(FormaPagamento formaPagamento);
        public void DeletarFormaPagamento(int formaPagamentoId);
        public void Salvar();
    }
}
