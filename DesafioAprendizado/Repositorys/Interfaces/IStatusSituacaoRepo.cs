using Entities.Models;
using Repositorys.DTO.StatusSituacaoDTO;

namespace Repositorys.Interfaces
{
    public interface IStatusSituacaoRepo
    {
        public void CriarStatusSituacao(StatusSituacao statusSituacao);
        public Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterStatusSituacao(int? statusSituacaoId);
        public void AtualizarStatusSituacao(StatusSituacao statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
        public void Salvar();
    }
}
