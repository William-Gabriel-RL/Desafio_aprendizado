using BusinessLayer.DTO.MesaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IMesaService
    {
        public void CriarMesa(CriarMesaDTO mesa);
        public Mesa? ObterMesaPorId(int mesaId);
        public Task<IEnumerable<Mesa>> ObterTodasMesas();
        public void AtualizarMesa(AtualizarMesaDTO mesa);
        public void DeletarMesa(int mesaId);
    }
}
