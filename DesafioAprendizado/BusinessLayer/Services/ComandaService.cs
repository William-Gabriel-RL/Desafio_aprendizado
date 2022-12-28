using BusinessLayer.DTO.ComandaDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Context;
using Repositorys.DTO.ComandaDTO;
using Repositorys.Interfaces;
using Repositorys.Repos;

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
                ComandaDataUltimaAtualizacao = DateTime.Now
            };
            _comandaRepo.AtualizarComanda(comanda);
        }

        public void CriarComanda(CriarComandaDTO criarComandaDTO, string matricula)
        {
            Comanda comanda = new()
            {
                AtendenteMatricula = matricula,
                MesaId = criarComandaDTO.MesaId
            };
            _comandaRepo.CriarComanda(comanda);
        }

        public void DeletarComanda(string ComandaId)
        {
            _comandaRepo.DeletarComanda(ComandaId);
        }

        public ExibirComandaDTO? ObterComandaPorId(string ComandaId)
        {
            return _comandaRepo.ObterComandaPorId(ComandaId);
        }

        public async Task<IEnumerable<ExibirComandaDTO>> ObterTodasComandas()
        {
            return await _comandaRepo.ObterTodasComandas();
        }

        public void ObterTotal(string comandaId)
        {
            _comandaRepo.ObterTotal(comandaId);
        }
    }
}
