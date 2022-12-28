using BusinessLayer.DTO.PagamentoDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Context;
using Repositorys.DTO.PagamentoDTO;
using Repositorys.Interfaces;
using Repositorys.Repos;

namespace BusinessLayer.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepo _pagamentoRepo;
        public PagamentoService()
        {
            _pagamentoRepo = new PagamentoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarPagamento(AtualizarPagamentoDTO atualizarPagamentoDTO)
        {
            Pagamento pagamento = new()
            {
                PagamentoId = atualizarPagamentoDTO.PagamentoId,
                Valor = atualizarPagamentoDTO.Valor,
                FormaPagamentoId = atualizarPagamentoDTO.FormaPagamentoId,
                ComandaId = new Guid(atualizarPagamentoDTO.ComandaId),
                UsuarioMatricula = atualizarPagamentoDTO.UsuarioMatricula,
                PagamentoDeletado = atualizarPagamentoDTO.PagamentoDeletado
            };
            _pagamentoRepo.AtualizarPagamento(pagamento);
        }

        public void CriarPagamento(CriarPagamentoDTO criarPagamentoDTO, string matricula)
        {
            Pagamento pagamento = new()
            {
                Valor = criarPagamentoDTO.Valor,
                FormaPagamentoId = criarPagamentoDTO.FormaPagamentoId,
                ComandaId = new Guid(criarPagamentoDTO.ComandaId),
                UsuarioMatricula = matricula
            };
            _pagamentoRepo.CriarPagamento(pagamento);
        }

        public void DeletarPagamento(int pagamentoId)
        {
            _pagamentoRepo.DeletarPagamento(pagamentoId);
        }

        public ExibirPagamentoDTO? ObterPagamentoPorId(int pagamentoId)
        {
            return _pagamentoRepo.ObterPagamentoPorId(pagamentoId);
        }

        public async Task<IEnumerable<ExibirPagamentoDTO>> ObterTodosPagamentos()
        {
            return await _pagamentoRepo.ObterTodosPagamentos();
        }
    }
}
