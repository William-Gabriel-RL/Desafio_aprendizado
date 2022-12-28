using BusinessLayer.DTO.ComandaDTO;
using Repositorys.DTO.ComandaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IComandaService
    {
        public void CriarComanda(CriarComandaDTO Comanda, string matricula);
        public ExibirComandaDTO? ObterComandaPorId(string ComandaId);
        public Task<IEnumerable<ExibirComandaDTO>> ObterTodasComandas();
        public void AtualizarComanda(AtualizarComandaDTO Comanda);
        public void ObterTotal(string comandaId);
        public void DeletarComanda(string ComandaId);
    }
}
