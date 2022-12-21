using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.StatusSituacaoDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class StatusSituacaoService : IStatusSituacaoService
    {
        private readonly IStatusSituacaoRepo _statusSituacaoRepo;
        public StatusSituacaoService()
        {
            _statusSituacaoRepo = new StatusSituacaoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarStatusSituacao(AtualizarStatusSituacaoDTO statusSituacao)
        {
            throw new NotImplementedException();
        }

        public void CriarStatusSituacao(CriarStatusSituacaoDTO statusSituacao)
        {
            throw new NotImplementedException();
        }

        public void DeletarStatusSituacao(int statusSituacaoId)
        {
            throw new NotImplementedException();
        }

        public StatusSituacao? ObterStatusSituacaoPorId(int statusSituacaoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StatusSituacao>> ObterTodosStatusSituacao()
        {
            throw new NotImplementedException();
        }
    }
}
