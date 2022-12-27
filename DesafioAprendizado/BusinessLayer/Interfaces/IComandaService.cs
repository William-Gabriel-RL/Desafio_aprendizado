using BusinessLayer.DTO.ComandaDTO;
using Entities.Models;
using Repositorys.DTO.ComandaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IComandaService
    {
        public void CriarComanda(CriarComandaDTO Comanda);
        public ExibirComandaDTO? ObterComandaPorId(string ComandaId);
        public Task<IEnumerable<ExibirComandaDTO>> ObterTodasComandas();
        public void AtualizarComanda(AtualizarComandaDTO Comanda);
        public void DeletarComanda(string ComandaId);
    }
}
