using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ComandaDTO;
using Entities.Models;

namespace BusinessLayer.Services
{
    public class ComandaService : IComandaService
    {
        private readonly IComandaRepo _comandaRepo;
        public ComandaService()
        {
            _comandaRepo = new ComandaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarComanda(AtualizarComandaDTO Comanda)
        {
            throw new NotImplementedException();
        }

        public void CriarComanda(CriarComandaDTO Comanda)
        {
            throw new NotImplementedException();
        }

        public void DeletarComanda(string ComandaId)
        {
            throw new NotImplementedException();
        }

        public Comanda? ObterComandaPorId(string ComandaId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comanda>> ObterTodasComandas()
        {
            throw new NotImplementedException();
        }
    }
}
