using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.StatusSituacaoDTO;
using Entities.Models;
using Repositorys.DTO.StatusSituacaoDTO;

namespace BusinessLayer.Services
{
    public class StatusSituacaoService : IStatusSituacaoService
    {
        private readonly IStatusSituacaoRepo _statusSituacaoRepo;
        public StatusSituacaoService()
        {
            _statusSituacaoRepo = new StatusSituacaoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarStatusSituacao(AtualizarStatusSituacaoDTO atualizarStatusSituacaoDTO)
        {
            StatusSituacao statusSituacao = new()
            {
                StatusSituacaoId = atualizarStatusSituacaoDTO.StatusSituacaoId,
                StatusSituacaoNome = atualizarStatusSituacaoDTO.StatusSituacaoNome,
                StatusSituacaoDeletado = atualizarStatusSituacaoDTO.StatusSituacaoDeletado,
                StatusSituacaoDataUltimaAtualizacao = DateTime.Now,
            };
            _statusSituacaoRepo.AtualizarStatusSituacao(statusSituacao);
        }

        public void CriarStatusSituacao(CriarStatusSituacaoDTO criarStatusSituacaoDTO)
        {
            StatusSituacao statusSituacao = new()
            {
                StatusSituacaoNome = criarStatusSituacaoDTO.StatusSituacaoNome
            };
            _statusSituacaoRepo.CriarStatusSituacao(statusSituacao);
        }

        public void DeletarStatusSituacao(int statusSituacaoId)
        {
            _statusSituacaoRepo.DeletarStatusSituacao(statusSituacaoId);
        }

        public ExibirStatusSituacaoDTO? ObterStatusSituacaoPorId(int statusSituacaoId)
        {
            return _statusSituacaoRepo.ObterStatusSituacaoPorId(statusSituacaoId);
        }

        public async Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterTodosStatusSituacao()
        {
            return await _statusSituacaoRepo.ObterTodosStatusSituacao();
        }
    }
}
