using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class FormaPagamentoRepo : IFormaPagamentoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public FormaPagamentoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarFormaPagamento(FormaPagamento formaPagamento)
        {
            _context.Update(formaPagamento);
            _context.SaveChanges();
        }

        public void CriarFormaPagamento(FormaPagamento formaPagamento)
        {
            _context.FormasPagamento.Add(formaPagamento);
            _context.SaveChanges();
        }

        public void DeletarFormaPagamento(int formaPagamentoId)
        {
            FormaPagamento? formaPagamento = _context.FormasPagamento.Find(formaPagamentoId);
            if (formaPagamento != null) 
            {
                if(formaPagamento.FormaPagamentoDeletado == false)
                {
                    formaPagamento.FormaPagamentoDeletado = true;
                    formaPagamento.FormaPagamentoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(formaPagamento);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Forma de pagamento já deletada");
                }
            }
            else
            {
                throw new Exception("Forma de pagamento não encontrada");
            }
        }

        public FormaPagamento? ObterFormaPagamentoPorId(int formaPagamentoId)
        {
            return _context.FormasPagamento.Find(formaPagamentoId);
        }

        public async Task<IEnumerable<FormaPagamento>> ObterTodasFormasPagamento()
        {
            return await _context.FormasPagamento.ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
