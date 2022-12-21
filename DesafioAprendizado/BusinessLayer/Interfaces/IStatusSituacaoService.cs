using BusinessLayer.DTO.StatusSituacaoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IStatusSituacaoService
    {
        public void CriarStatusSituacao(CriarStatusSituacaoDTO statusSituacao);
        public StatusSituacao? ObterStatusSituacaoPorId(int statusSituacaoId);
        public Task<IEnumerable<StatusSituacao>> ObterTodosStatusSituacao();
        public void AtualizarStatusSituacao(AtualizarStatusSituacaoDTO statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
    }
}
