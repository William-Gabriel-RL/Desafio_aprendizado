using Entities.Models;
using Repositorys.DTO.PagamentoDTO;

namespace Repositorys.Interfaces
{
    public interface IPagamentoRepo
    {
        public void CriarPagamento(Pagamento pagamento);
        public Task<IEnumerable<ExibirPagamentoDTO>> ObterPagamentos(int? pagamentoId, int? formaPagamentoId, string? comandaId, string? usuarioMatricula, int? ano, int? mes, int? dia);
        public void AtualizarPagamento(Pagamento pagamento);
        public void DeletarPagamento(int pagamentoId);
        public void Salvar();
    }
}
