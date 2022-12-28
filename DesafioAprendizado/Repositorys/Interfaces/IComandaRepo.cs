using Entities.Models;
using Repositorys.DTO.ComandaDTO;

namespace Repositorys.Interfaces
{
    public interface IComandaRepo
    {
        public void CriarComanda(Comanda Comanda);
        public ExibirComandaDTO? ObterComandaPorId(string ComandaId);
        public Task<IEnumerable<ExibirComandaDTO>> ObterTodasComandas();
        public void AtualizarComanda(Comanda Comanda);
        public void DeletarComanda(string ComandaId);
        public void ObterTotal(string comandaId);
        public void Salvar();
    }
}
