using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IMesaRepo
    {
        public void CriarMesa(Mesa mesa);
        public Mesa? ObterMesaPorId(int mesaId);
        public Task<IEnumerable<Mesa>> ObterTodasMesas();
        public void AtualizarMesa(Mesa mesa);
        public void DeletarMesa(int mesaId);
        public void Salvar();
    }
}
