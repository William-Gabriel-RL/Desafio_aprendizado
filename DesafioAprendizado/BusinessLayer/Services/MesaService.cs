using BusinessLayer.DTO.MesaDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Context;
using Repositorys.Interfaces;
using Repositorys.Repos;

namespace BusinessLayer.Services
{
    public class MesaService : IMesaService
    {
        private readonly IMesaRepo _mesaRepo;
        public MesaService()
        {
            _mesaRepo = new MesaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarMesa(AtualizarMesaDTO mesa)
        {
            throw new NotImplementedException();
        }

        public void CriarMesa(CriarMesaDTO mesa)
        {
            throw new NotImplementedException();
        }

        public void DeletarMesa(int mesaId)
        {
            throw new NotImplementedException();
        }

        public Mesa? ObterMesaPorId(int mesaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mesa>> ObterTodasMesas()
        {
            throw new NotImplementedException();
        }
    }
}
