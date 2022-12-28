using BusinessLayer.DTO.StatusSituacaoDTO;
using Entities.Models;
using Repositorys.DTO.StatusSituacaoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IStatusSituacaoService
    {
        public void CriarStatusSituacao(CriarStatusSituacaoDTO statusSituacao);
        public ExibirStatusSituacaoDTO? ObterStatusSituacaoPorId(int statusSituacaoId);
        public Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterTodosStatusSituacao();
        public void AtualizarStatusSituacao(AtualizarStatusSituacaoDTO statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
    }
}
