using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.StatusSituacaoDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class StatusSituacaoRepo : IStatusSituacaoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public StatusSituacaoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarStatusSituacao(StatusSituacao statusSituacao)
        {
            _context.Update(statusSituacao);
            _context.SaveChanges();
        }

        public void CriarStatusSituacao(StatusSituacao statusSituacao)
        {
            _context.StatusSituacao.Add(statusSituacao);
            _context.SaveChanges();
        }

        public void DeletarStatusSituacao(int statusSituacaoId)
        {
            StatusSituacao? status = _context.StatusSituacao.Find(statusSituacaoId);
            if (status != null)
            {
                if (status.StatusSituacaoDeletado == false)
                {
                    status.StatusSituacaoDeletado = true;
                    status.StatusSituacaoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(status);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Status já deletado");
                }
            }
            else
            {
                throw new Exception("Status não encontrado");
            }
        }

        public ExibirStatusSituacaoDTO? ObterStatusSituacaoPorId(int statusSituacaoId)
        {
            return _context.StatusSituacao
                .Where(x => x.StatusSituacaoDeletado == false)
                .Select(x => new ExibirStatusSituacaoDTO
                {
                    StatusSituacaoId = x.StatusSituacaoId,
                    StatusSituacaoNome = x.StatusSituacaoNome,
                    StatusSituacaoDataUltimaAtualizacao = x.StatusSituacaoDataUltimaAtualizacao
                })
                .FirstOrDefault(x => x.StatusSituacaoId == statusSituacaoId);
        }

        public async Task<IEnumerable<ExibirStatusSituacaoDTO>> ObterTodosStatusSituacao()
        {
            return await _context.StatusSituacao
                .Where(x => x.StatusSituacaoDeletado == false)
                .Select(x => new ExibirStatusSituacaoDTO
                {
                    StatusSituacaoId = x.StatusSituacaoId,
                    StatusSituacaoNome = x.StatusSituacaoNome,
                    StatusSituacaoDataUltimaAtualizacao = x.StatusSituacaoDataUltimaAtualizacao
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
