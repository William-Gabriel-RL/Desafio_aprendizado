using Entities.Models;
using Repositorys.DTO.MesaDTO;

namespace Repositorys.Interfaces
{
    public interface IMesaRepo
    {
        public void CriarMesa(Mesa mesa);
        public Task<IEnumerable<ExibirMesaDTO>> ObterMesas(int? mesaId);
        public void AtualizarMesa(Mesa mesa);
        public void DeletarMesa(int mesaId);
        public void Salvar();
    }
}
