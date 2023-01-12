using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Repositorys.Context;
using Repositorys.DTO.ComandaDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ComandaRepo : IComandaRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ComandaRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarComanda(Comanda Comanda)
        {
            _context.Comandas.Update(Comanda);
            _context.SaveChanges();
        }

        public void CriarComanda(Comanda Comanda)
        {
            _context.Comandas.Add(Comanda);
            _context.SaveChanges();
        }

        public void DeletarComanda(string comandaId)
        {
            Comanda? comanda = _context.Comandas.Find(new Guid(comandaId));
            if (comanda != null)
            {
                if (comanda.ComandaDeletado == false)
                {
                    comanda.ComandaDeletado = true;
                    comanda.ComandaDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(comanda);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Comanda já deletada");
                }
            }
            else
            {
                throw new Exception("Comanda não encontrada");
            }
        }

        public async Task<IEnumerable<ExibirComandaDTO>> ObterComandas(string? comandaId, bool? finalizada, string? usuarioMatricula, int? mesaId, int? ano, int? mes, int? dia)
        {
            var comandas = _context.Comandas.Where(x => x.ComandaDeletado == false);
            if (comandaId != null)
                comandas = comandas.Where(x => x.ComandaId.ToString() == comandaId);
            if (finalizada != null)
                comandas = comandas.Where(x => x.ComandaFinalizada == finalizada);
            if (usuarioMatricula != null)
                comandas = comandas.Where(x => x.AtendenteMatricula == usuarioMatricula);
            if (mesaId != null)
                comandas = comandas.Where(x => x.MesaId == mesaId);
            if (ano != null)
                comandas = comandas.Where(x => x.ComandaHoraAbertura.Year == ano);
            if (mes != null)
                comandas = comandas.Where(x => x.ComandaHoraAbertura.Month == mes);
            if (dia != null)
                comandas = comandas.Where(x => x.ComandaHoraAbertura.Day == dia);

            return await comandas.Select(x => new ExibirComandaDTO
            {
                ComandaId = x.ComandaId,
                ComandaHoraAbertura = x.ComandaHoraAbertura,
                ComandaTotal = x.ComandaTotal,
                ComandaFinalizada = x.ComandaFinalizada,
                ComandaDataUltimaAtualizacao = x.ComandaDataUltimaAtualizacao,
                AtendenteMatricula = x.AtendenteMatricula,
                Atendente = x.Atendente.UsuarioNome,
                MesaId = x.MesaId,
                Mesa = x.Mesa.MesaNome,
                ProdutosComanda = x.ProdutosComanda
                        .Where(x => x.ProdutoComandaDeletado == false)
                        .Select(x => new ComandaExibirProdutoComanda
                        {
                            ProdutoComandaQuantidadeProdutos = x.ProdutoComandaQuantidadeProdutos,
                            ProdutoComandaNome = x.Produto.ProdutoNome,
                            ProdutoComandaPreco = x.ProdutoComandaPreco,
                            ProdutoComandaObservacao = x.ProdutoComandaObservacao
                        }),
                Pagamento = x.Pagamento
                        .Where(x => x.PagamentoDeletado == false)
                        .Select(x => new ComandaExibirPagamento
                        {
                            PagamentoId = x.PagamentoId,
                            PagamentoDataHora = x.PagamentoDataHora,
                            Valor = x.Valor,
                            FormaPagamentoId = x.FormaPagamentoId,
                            FormaPagamento = x.FormaPagamento.FormaPagamentoNome,
                            UsuarioMatricula = x.UsuarioMatricula,
                            UsuarioNome = x.Usuario.UsuarioNome,
                            PagamentoDataUltimaAtualizacao = x.PagamentoDataUltimaAtualizacao
                        })
            }).ToListAsync();
        }

        public void ObterTotal(string comandaId)
        {
            Comanda? comanda = _context.Comandas.Find(new Guid(comandaId));
            comanda.ComandaTotal = _context.ProdutosComandas
                .Where(x => x.ComandaId == new Guid(comandaId))
                .Select(x => x.ProdutoComandaPreco)
                .Sum();
            _context.SaveChanges();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
