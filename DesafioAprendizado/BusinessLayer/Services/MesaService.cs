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

        public void AtualizarMesa(AtualizarMesaDTO atualizarMesaDTO)
        {
            Mesa mesa = new()
            {
                MesaId = atualizarMesaDTO.MesaId,
                MesaOcupada = atualizarMesaDTO.MesaOcupada,
                MesaDeletada = atualizarMesaDTO.MesaDeletada,
                MesaDataUltimaAtualizacao = DateTime.Now
            };
            _mesaRepo.AtualizarMesa(mesa);
        }

        public void CriarMesa(CriarMesaDTO criarMesaDTO)
        {
            Mesa mesa = new();
            _mesaRepo.CriarMesa(mesa);
        }

        public void DeletarMesa(int mesaId)
        {
            _mesaRepo.DeletarMesa(mesaId);
        }

        public Mesa? ObterMesaPorId(int mesaId)
        {
            return _mesaRepo.ObterMesaPorId(mesaId);
        }

        public async Task<IEnumerable<Mesa>> ObterTodasMesas()
        {
            return await _mesaRepo.ObterTodasMesas();
        }
    }
}
