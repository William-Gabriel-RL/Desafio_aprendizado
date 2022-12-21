using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IStatusSituacaoRepo
    {
        public void CriarStatusSituacao(StatusSituacao statusSituacao);
        public StatusSituacao? ObterStatusSituacaoPorId(int statusSituacaoId);
        public Task<IEnumerable<StatusSituacao>> ObterTodosStatusSituacao();
        public void AtualizarStatusSituacao(StatusSituacao statusSituacao);
        public void DeletarStatusSituacao(int statusSituacaoId);
        public void Salvar();
    }
}
