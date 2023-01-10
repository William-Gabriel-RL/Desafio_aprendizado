using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.MesaDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class MesaRepo : IMesaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public MesaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarMesa(Mesa mesa)
        {
            _context.Update(mesa);
            _context.SaveChanges();
        }

        public void CriarMesa(Mesa mesa)
        {
            _context.Mesas.Add(mesa);
            _context.SaveChanges();
        }

        public void DeletarMesa(int mesaId)
        {
            Mesa? mesa = _context.Mesas.Find(mesaId);
            if (mesa != null)
            {
                if (mesa.MesaDeletada == false)
                {
                    mesa.MesaDeletada = true;
                    mesa.MesaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(mesa);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Mesa já deletada");
                }
            }
            else
            {
                throw new Exception("Mesa não encontrada");
            }
        }

        public async Task<IEnumerable<ExibirMesaDTO>> ObterMesas(int? mesaId)
        {
            var mesas = _context.Mesas.Where(x => x.MesaDeletada != false);
            if (mesaId != null)
                mesas = mesas.Where(x => x.MesaId == mesaId);

            return await mesas.Select(x => new ExibirMesaDTO
            {
                MesaId = x.MesaId,
                MesaOcupada = x.MesaOcupada,
                MesaDataUltimaAtualizacao = x.MesaDataUltimaAtualizacao
            }).ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
