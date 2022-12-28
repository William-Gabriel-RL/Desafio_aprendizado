using Entities.Models;
using Repositorys.DTO.ComandaDTO;

namespace Repositorys.Interfaces
{
    public interface IComandaRepo
    {
        public void CriarComanda(Comanda Comanda);
        public Task<IEnumerable<ExibirComandaDTO>> ObterComandas(string? comandaId, bool? finalizada, string? usuarioMatricula, int? mesaId);
        public void AtualizarComanda(Comanda Comanda);
        public void DeletarComanda(string ComandaId);
        public void ObterTotal(string comandaId);
        public void Salvar();
    }
}
