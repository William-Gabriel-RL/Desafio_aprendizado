using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IComandaRepo
    {
        public void CriarComanda(Comanda Comanda);
        public Comanda? ObterComandaPorId(string ComandaId);
        public Task<IEnumerable<Comanda>> ObterTodasComandas();
        public void AtualizarComanda(Comanda Comanda);
        public void DeletarComanda(string ComandaId);
        public void Salvar();
    }
}
