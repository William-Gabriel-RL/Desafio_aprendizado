using Entities.Models;
using Repositorys.DTO.FormaPagamentoDTO;

namespace Repositorys.Interfaces
{
    public interface IFormaPagamentoRepo
    {
        public void CriarFormaPagamento(FormaPagamento formaPagamento);
        public Task<IEnumerable<ExibirFormaPagamentoDTO>> ObterFormasPagamento(int? formaPagamentoId);
        public void AtualizarFormaPagamento(FormaPagamento formaPagamento);
        public void DeletarFormaPagamento(int formaPagamentoId);
        public void Salvar();
    }
}
