using BusinessLayer.DTO.FormaPagamentoDTO;
using Entities.Models;
using Repositorys.DTO.FormaPagamentoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IFormaPagamentoService
    {
        public void CriarFormaPagamento(CriarFormaPagamentoDTO criarFormaPagamentoDTO);
        public Task<IEnumerable<ExibirFormaPagamentoDTO>> ObterFormasPagamento(int? formaPagamentoId);
        public void AtualizarFormaPagamento(AtualizarFormaPagamentoDTO atualizarFormaPagamentoDTO);
        public void DeletarFormaPagamento(int formaPagamentoId);
    }
}
