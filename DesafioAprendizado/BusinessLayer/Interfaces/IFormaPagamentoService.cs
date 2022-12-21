using BusinessLayer.DTO.FormaPagamentoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IFormaPagamentoService
    {
        public void CriarFormaPagamento(CriarFormaPagamentoDTO criarFormaPagamentoDTO);
        public FormaPagamento? ObterFormaPagamentoPorId(int formaPagamentoId);
        public Task<IEnumerable<FormaPagamento>> ObterTodasFormasPagamento();
        public void AtualizarFormaPagamento(AtualizarFormaPagamentoDTO atualizarFormaPagamentoDTO);
        public void DeletarFormaPagamento(int formaPagamentoId);
    }
}
