using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ComandaRepo : IComandaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ComandaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarComanda(Comanda Comanda)
        {
            _context.Update(Comanda);
            _context.SaveChanges();
        }

        public void CriarComanda(Comanda Comanda)
        {
            _context.Comandas.Add(Comanda);
            _context.SaveChanges();
        }

        public void DeletarComanda(string comandaId)
        {
            Comanda? comanda = _context.Comandas.Find(comandaId);
            if (comanda != null) 
            {
                if (comanda.ComandaDeletado == false)
                {
                    comanda.ComandaDeletado = true;
                    comanda.ComandaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(comanda);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Comanda já deletada");
                }
            }
            else
            {
                throw new Exception("Comanda não encontrada");
            }
        }

        public Comanda? ObterComandaPorId(string comandaId)
        {
            return _context.Comandas.Find(comandaId);
        }

        public async Task<IEnumerable<Comanda>> ObterTodasComandas()
        {
            return await _context.Comandas.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
