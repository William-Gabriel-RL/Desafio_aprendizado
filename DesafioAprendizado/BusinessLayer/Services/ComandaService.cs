using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ComandaDTO;
using Entities.Models;
using System.ComponentModel.Design;

namespace BusinessLayer.Services
{
    public class ComandaService : IComandaService
    {
        private readonly IComandaRepo _comandaRepo;
        public ComandaService()
        {
            _comandaRepo = new ComandaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarComanda(AtualizarComandaDTO atualizarComandaDTO)
        {
            Comanda comanda = new()
            {
                ComandaId = new Guid(atualizarComandaDTO.ComandaId),
                ComandaFinalizada = atualizarComandaDTO.ComandaFinalizada,
                ComandaDeletado = atualizarComandaDTO.ComandaDeletado,
                AtendenteMatricula = atualizarComandaDTO.AtendenteMatricula,
                MesaId = atualizarComandaDTO.MesaId,
                PagamentoId = atualizarComandaDTO.PagamentoId,
                ComandaDataUltimaAtualizacao = DateTime.Now
            };
            _comandaRepo.AtualizarComanda(comanda);
        }

        public void CriarComanda(CriarComandaDTO criarComandaDTO)
        {
            Comanda comanda = new()
            {
                AtendenteMatricula = criarComandaDTO.AtendenteMatricula,
                MesaId = criarComandaDTO.MesaId
            };
            _comandaRepo.CriarComanda(comanda);
        }

        public void DeletarComanda(string ComandaId)
        {
            _comandaRepo.DeletarComanda(ComandaId);
        }

        public Comanda? ObterComandaPorId(string ComandaId)
        {
            return _comandaRepo.ObterComandaPorId(ComandaId);
        }

        public async Task<IEnumerable<Comanda>> ObterTodasComandas()
        {
            return await _comandaRepo.ObterTodasComandas();
        }
    }
}
