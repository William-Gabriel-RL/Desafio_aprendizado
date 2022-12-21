using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }else
            {
                throw new Exception("Mesa não encontrada");
            }
        }

        public Mesa? ObterMesaPorId(int mesaId)
        {
            return _context.Mesas.Find(mesaId);
        }

        public async Task<IEnumerable<Mesa>> ObterTodasMesas()
        {
            return await _context.Mesas.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
