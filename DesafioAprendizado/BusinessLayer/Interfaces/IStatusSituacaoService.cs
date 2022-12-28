using BusinessLayer.DTO.StatusSituacaoDTO;
using Entities.Models;
using Repositorys.DTO.StatusSituacaoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IStatusSituacaoService
    {
        public void CriarStatusSituacao(CriarStatusSituacaoDTO statusSituacao);
        public Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterStatusSituacao(int? statusSituacaoId);
        public void AtualizarStatusSituacao(AtualizarStatusSituacaoDTO statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
    }
}
