using Entities.Models;
using Repositorys.DTO.MesaDTO;

namespace Repositorys.Interfaces
{
    public interface IMesaRepo
    {
        public void CriarMesa(Mesa mesa);
        public ExibirMesaDTO? ObterMesaPorId(int mesaId);
        public Task<IEnumerable<ExibirMesaDTO>> ObterTodasMesas();
        public void AtualizarMesa(Mesa mesa);
        public void DeletarMesa(int mesaId);
        public void Salvar();
    }
}
