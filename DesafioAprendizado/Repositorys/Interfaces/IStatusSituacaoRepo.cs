using Entities.Models;
using Repositorys.DTO.StatusSituacaoDTO;

namespace Repositorys.Interfaces
{
    public interface IStatusSituacaoRepo
    {
        public void CriarStatusSituacao(StatusSituacao statusSituacao);
        public ExibirStatusSituacaoDTO? ObterStatusSituacaoPorId(int statusSituacaoId);
        public Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterTodosStatusSituacao();
        public void AtualizarStatusSituacao(StatusSituacao statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
        public void Salvar();
    }
}
