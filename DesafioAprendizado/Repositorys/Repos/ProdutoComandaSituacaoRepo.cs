﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class ProdutoComandaSituacaoRepo : IProdutoComandaSituacaoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public ProdutoComandaSituacaoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao)
        {
            _context.Update(produtoComandaSituacao);
            _context.SaveChanges();
        }

        public void CriarProdutoComandaSituacao(ProdutoComandaSituacao produtoComandaSituacao)
        {
            _context.ProdutosComandasSituacoes.Add(produtoComandaSituacao);
            _context.SaveChanges();
        }

        public void DeletarProdutoComandaSituacao(int produtoComandaSituacaoId)
        {
            ProdutoComandaSituacao? produtoComandaSituacao = _context.ProdutosComandasSituacoes.Find(produtoComandaSituacaoId);
            if (produtoComandaSituacao != null)
            {
                if (produtoComandaSituacao.ProdutoComandaSituacaoDeletado == false)
                {
                    produtoComandaSituacao.ProdutoComandaSituacaoDeletado = true;
                    produtoComandaSituacao.ProdutoComandaSituacaoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(produtoComandaSituacao);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Situação do produto da comanda já deletada");
                }
            }
            else
            {
                throw new Exception("Situação do produto da comanda não encontrada");
            }
        }

        public async Task<IEnumerable<ExibirProdutoComandaSituacaoDTO>> ObterProdutosComandaSituacao(int? produtoComandaSituacaoId, string? usuarioMatricula, int? statusSituacaoId, int? ano, int? mes, int? dia)
        {
            var produtoComandasSituacoes = _context.ProdutosComandasSituacoes.Where(x => x.ProdutoComandaSituacaoDeletado == false);
            if (produtoComandaSituacaoId != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.ProdutoComandaSituacaoId == produtoComandaSituacaoId);
            if (usuarioMatricula != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.UsuarioMatricula == usuarioMatricula);
            if (statusSituacaoId != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.StatusSituacaoId == statusSituacaoId);
            if (ano != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.ProdutoComandaSituacaoDataHora.Year == ano);
            if (mes != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.ProdutoComandaSituacaoDataHora.Month == mes);
            if (dia != null)
                produtoComandasSituacoes = produtoComandasSituacoes.Where(x => x.ProdutoComandaSituacaoDataHora.Day == dia);

            return await produtoComandasSituacoes.Select(x => new ExibirProdutoComandaSituacaoDTO
            {
                ProdutoComandaSituacaoId = x.ProdutoComandaSituacaoId,
                ProdutoComandaSituacaoDataHora = x.ProdutoComandaSituacaoDataHora,
                ProdutoComandaSituacaoMotivo = x.ProdutoComandaSituacaoMotivo,
                ProdutoComandaSituacaoDataUltimaAtualizacao = x.ProdutoComandaSituacaoDataUltimaAtualizacao,
                UsuarioMatricula = x.UsuarioMatricula,
                UsuarioNome = x.Usuario.UsuarioNome,
                UsuarioTipo = x.Usuario.Tipo.UsuarioTipoNome,
                StatusSituacaoId = x.StatusSituacaoId,
                StatusSituacaoNome = x.StatusSituacao.StatusSituacaoNome,
                ProdutoComandaId = x.ProdutoComandaId
            }).ToListAsync();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
