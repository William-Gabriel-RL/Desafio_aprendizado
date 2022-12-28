using BusinessLayer.DTO.PagamentoDTO;
using Entities.Models;
using Repositorys.DTO.PagamentoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IPagamentoService
    {
        public void CriarPagamento(CriarPagamentoDTO pagamento, string matricula);
        public Task<IEnumerable<ExibirPagamentoDTO>> ObterPagamentos(int? pagamentoId, int? formaPagamentoId, string? comandaId, string? usuarioMatricula);
        public void AtualizarPagamento(AtualizarPagamentoDTO pagamento);
        public void DeletarPagamento(int pagamentoId);
    }
}
