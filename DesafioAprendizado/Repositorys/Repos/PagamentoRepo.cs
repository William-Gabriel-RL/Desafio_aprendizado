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

        public async Task<IEnumerable<ExibirPagamentoDTO>> ObterPagamentos(int? pagamentoId, int? formaPagamentoId, string? comandaId, string? usuarioMatricula, int? ano, int? mes, int? dia)
        {
            var pagamentos = _context.Pagamentos.Where(x => x.PagamentoDeletado == false);
            if (pagamentoId != null)
                pagamentos = pagamentos.Where(x => x.PagamentoId== pagamentoId);
            if (formaPagamentoId != null)
                pagamentos = pagamentos.Where(x => x.FormaPagamentoId== formaPagamentoId);
            if (comandaId != null)
                pagamentos = pagamentos.Where(x => x.ComandaId.ToString() == comandaId);
            if (usuarioMatricula != null)
                pagamentos = pagamentos.Where(x => x.UsuarioMatricula == usuarioMatricula);
            if (ano != null)
                pagamentos = pagamentos.Where(x => x.PagamentoDataHora.Year == ano);
            if (mes != null)
                pagamentos = pagamentos.Where(x => x.PagamentoDataHora.Month == mes);
            if (dia != null)
                pagamentos = pagamentos.Where(x => x.PagamentoDataHora.Day == dia);

            return await pagamentos.Select(x => new ExibirPagamentoDTO
            {
                PagamentoId = x.PagamentoId,
                PagamentoDataHora = x.PagamentoDataHora,
                Valor = x.Valor,
                FormaPagamentoId = x.FormaPagamentoId,
                FormaPagamento = x.FormaPagamento.FormaPagamentoNome,
                ComandaId = x.ComandaId,
                UsuarioMatricula = x.UsuarioMatricula,
                UsuarioNome = x.Usuario.UsuarioNome,
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
