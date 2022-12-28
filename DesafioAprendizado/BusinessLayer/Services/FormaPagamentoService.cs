using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.FormaPagamentoDTO;
using Entities.Models;
using Repositorys.DTO.FormaPagamentoDTO;

namespace BusinessLayer.Services
{
    public class FormaPagamentoService : IFormaPagamentoService
    {
        private readonly IFormaPagamentoRepo _formaPagamentoRepo;
        public FormaPagamentoService()
        {
            _formaPagamentoRepo = new FormaPagamentoRepo(new DesafioAprendizadoContext());
        }

        public void AtualizarFormaPagamento(AtualizarFormaPagamentoDTO atualizarFormaPagamentoDTO)
        {
            FormaPagamento formaPagamento = new()
            {
                FormaPagamentoId = atualizarFormaPagamentoDTO.FormaPagamentoId,
                FormaPagamentoNome = atualizarFormaPagamentoDTO.FormaPagamentoNome,
                FormaPagamentoDeletado = atualizarFormaPagamentoDTO.FormaPagamentoDeletado,
                FormaPagamentoDataUltimaAtualizacao = DateTime.Now
            };
            _formaPagamentoRepo.AtualizarFormaPagamento(formaPagamento);
        }

        public void CriarFormaPagamento(CriarFormaPagamentoDTO criarFormaPagamentoDTO)
        {
            FormaPagamento formaPagamento = new()
            {
                FormaPagamentoNome = criarFormaPagamentoDTO.FormaPagamentoNome
            };
            _formaPagamentoRepo.CriarFormaPagamento(formaPagamento);
        }

        public void DeletarFormaPagamento(int formaPagamentoId)
        {
            _formaPagamentoRepo.DeletarFormaPagamento(formaPagamentoId);
        }

        public ExibirFormaPagamentoDTO? ObterFormaPagamentoPorId(int formaPagamentoId)
        {
            return _formaPagamentoRepo.ObterFormaPagamentoPorId(formaPagamentoId);
        }

        public Task<IEnumerable<ExibirFormaPagamentoDTO>> ObterTodasFormasPagamento()
        {
            return _formaPagamentoRepo.ObterTodasFormasPagamento();
        }
    }
}
