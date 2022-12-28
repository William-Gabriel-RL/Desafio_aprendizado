using BusinessLayer.DTO.ComandaDTO;
using Repositorys.DTO.ComandaDTO;

namespace BusinessLayer.Interfaces
{
    public interface IComandaService
    {
        public void CriarComanda(CriarComandaDTO Comanda, string matricula);
        public Task<IEnumerable<ExibirComandaDTO>> ObterComandas(string? comandaId, bool? finalizada, string? usuarioMatricula, int? mesaId);
        public void AtualizarComanda(AtualizarComandaDTO Comanda);
        public void ObterTotal(string comandaId);
        public void DeletarComanda(string ComandaId);
    }
}
