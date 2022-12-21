using BusinessLayer.DTO.ComandaDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IComandaService
    {
        public void CriarComanda(CriarComandaDTO Comanda);
        public Comanda? ObterComandaPorId(string ComandaId);
        public Task<IEnumerable<Comanda>> ObterTodasComandas();
        public void AtualizarComanda(AtualizarComandaDTO Comanda);
        public void DeletarComanda(string ComandaId);
    }
}
