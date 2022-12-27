using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.PagamentoDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class PagamentoRepo : IPagamentoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public PagamentoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarPagamento(Pagamento pagamento)
        {
            _context.Update(pagamento);
            _context.SaveChanges();
        }

        public void CriarPagamento(Pagamento pagamento)
        {
            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
        }

        public void DeletarPagamento(int pagamentoId)
        {
            Pagamento? pagamento = _context.Pagamentos.Find(pagamentoId);
            if (pagamento != null)
            {
                if (pagamento.PagamentoDeletado == false)
                {
                    pagamento.PagamentoDeletado = true;
                    pagamento.PagamentoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(pagamento);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Pagamento já deletado");
                }
            }
            else
            {
                throw new Exception("Pagamento não encontrado");
            }
        }

        public ExibirPagamentoDTO? ObterPagamentoPorId(int pagamentoId)
        {
            return _context.Pagamentos
                .Select(x => new ExibirPagamentoDTO
                {
                    PagamentoId = x.PagamentoId,
                    PagamentoDataHora = x.PagamentoDataHora,
                    Valor = x.Valor,
                    FormaPagamentoId = x.FormaPagamentoId,
                    FormaPagamento = x.FormaPagamento.FormaPagamentoNome,
                    ComandaId = x.ComandaId,
                    UsuarioMatricula = x.UsuarioMatricula,
                    UsuarioNome = x.Usuario.UsuarioNome,
                    PagamentoDeletado = x.PagamentoDeletado,
                    PagamentoDataUltimaAtualizacao = x.PagamentoDataUltimaAtualizacao
                })
                .FirstOrDefault(x => x.PagamentoId == pagamentoId);
        }

        public async Task<IEnumerable<ExibirPagamentoDTO>> ObterTodosPagamentos()
        {
            return await _context.Pagamentos
                .Select(x => new ExibirPagamentoDTO
                {
                    PagamentoId = x.PagamentoId,
                    PagamentoDataHora = x.PagamentoDataHora,
                    Valor = x.Valor,
                    FormaPagamentoId = x.FormaPagamentoId,
                    FormaPagamento = x.FormaPagamento.FormaPagamentoNome,
                    ComandaId = x.ComandaId,
                    UsuarioMatricula = x.UsuarioMatricula,
                    UsuarioNome = x.Usuario.UsuarioNome,
                    PagamentoDeletado = x.PagamentoDeletado,
                    PagamentoDataUltimaAtualizacao = x.PagamentoDataUltimaAtualizacao
                })
                .ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
