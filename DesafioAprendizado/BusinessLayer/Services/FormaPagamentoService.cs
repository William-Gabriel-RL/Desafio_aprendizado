using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using BusinessLayer.Interfaces;
using BusinessLayer.DTO.FormaPagamentoDTO;
using Entities.Models;

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
            throw new NotImplementedException();
        }

        public void CriarFormaPagamento(CriarFormaPagamentoDTO criarFormaPagamentoDTO)
        {
            throw new NotImplementedException();
        }

        public void DeletarFormaPagamento(int formaPagamentoId)
        {
            throw new NotImplementedException();
        }

        public FormaPagamento? ObterFormaPagamentoPorId(int formaPagamentoId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FormaPagamento>> ObterTodasFormasPagamento()
        {
            throw new NotImplementedException();
        }
    }
}
