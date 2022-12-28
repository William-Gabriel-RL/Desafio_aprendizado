using BusinessLayer.DTO.FormaPagamentoDTO;
using Entities.Models;
using Repositorys.DTO.FormaPagamentoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IFormaPagamentoService
    {
        public void CriarFormaPagamento(CriarFormaPagamentoDTO criarFormaPagamentoDTO);
        public ExibirFormaPagamentoDTO? ObterFormaPagamentoPorId(int formaPagamentoId);
        public Task<IEnumerable<ExibirFormaPagamentoDTO>> ObterTodasFormasPagamento();
        public void AtualizarFormaPagamento(AtualizarFormaPagamentoDTO atualizarFormaPagamentoDTO);
        public void DeletarFormaPagamento(int formaPagamentoId);
    }
}
