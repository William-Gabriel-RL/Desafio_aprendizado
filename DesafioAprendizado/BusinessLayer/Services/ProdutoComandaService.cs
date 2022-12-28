using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.ProdutoComandaDTO;
using Entities.Models;
using Repositorys.DTO.ProdutoComandaDTO;

namespace BusinessLayer.Services
{
    public class ProdutoComandaService : IProdutoComandaService
    {
        private readonly IProdutoComandaRepo _produtoComandaRepo;
        public ProdutoComandaService()
        {
            _produtoComandaRepo = new ProdutoComandaRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarProdutoComanda(AtualizarProdutoComandaDTO atualizarProdutoComandaDTO)
        {
            ProdutoComanda produtoComanda = new()
            {
                ProdutoComandaId = atualizarProdutoComandaDTO.ProdutoId,
                ProdutoComandaQuantidadeProdutos = atualizarProdutoComandaDTO.ProdutoComandaQuantidadeProdutos,
                ProdutoComandaPreco = atualizarProdutoComandaDTO.ProdutoComandaPreco,
                ProdutoComandaObservacao = atualizarProdutoComandaDTO.ProdutoComandaObservacao,
                ProdutoId = atualizarProdutoComandaDTO.ProdutoId,
                ComandaId = new Guid(atualizarProdutoComandaDTO.ComandaId),
                ProdutoComandaDeletado = atualizarProdutoComandaDTO.ProdutoComandaDeletado,
                ProdutoComandaDataUltimaAtualizacao = DateTime.Now
            };
            _produtoComandaRepo.AtualizarProdutoComanda(produtoComanda);
        }

        public void CriarProdutoComanda(CriarProdutoComandaDTO criarProdutoComandaDTO)
        {
            ProdutoComanda produtoComanda = new()
            {
                ProdutoComandaQuantidadeProdutos = criarProdutoComandaDTO.ProdutoComandaQuantidadeProdutos,
                ProdutoComandaObservacao = criarProdutoComandaDTO.ProdutoComandaObservacao,
                ProdutoId = criarProdutoComandaDTO.ProdutoId,
                ComandaId = new Guid(criarProdutoComandaDTO.ComandaId)
            };
            _produtoComandaRepo.CriarProdutoComanda(produtoComanda);
        }

        public void DeletarProdutoComanda(int produtoComandaId)
        {
            _produtoComandaRepo.DeletarProdutoComanda(produtoComandaId);
        }

        public async Task<IEnumerable<ExibirProdutoComandaDTO>> ObterProdutoComanda(int? produtoComandaId, int? produtoId, string? comandaId)
        {
            return await _produtoComandaRepo.ObterProdutoComanda(produtoComandaId, produtoId, comandaId);
        }
    }
}
