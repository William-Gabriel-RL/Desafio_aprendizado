using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.UsuarioTipoDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class UsuarioTipoRepo : IUsuarioTipoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public UsuarioTipoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarUsuarioTipo(UsuarioTipo usuarioTipo)
        {
            _context.Entry(usuarioTipo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarUsuarioTipo(UsuarioTipo usuarioTipo)
        {
            _context.UsuarioTipos.Add(usuarioTipo);
            _context.SaveChanges();
        }

        public void DeletarUsuarioTipo(int usuarioTipoId)
        {
            UsuarioTipo? usuarioTipo = _context.UsuarioTipos.Find(usuarioTipoId);
            if (usuarioTipo != null)
            {
                if (usuarioTipo.UsuarioTipoDeletado == false)
                {
                    usuarioTipo.UsuarioTipoDeletado = true;
                    usuarioTipo.UsuarioTipoDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(usuarioTipo);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Tipo de usuário já deletado");
                }
            }
            else
            {
                throw new Exception("Tipo de usuário não encontrado");
            }
        }

        public async Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterUsuarioTipos(int? usuarioTipoId)
        {
            var usuarioTipos = _context.UsuarioTipos.Where(x => x.UsuarioTipoDeletado == false);
            if (usuarioTipoId != null)
                usuarioTipos = usuarioTipos.Where(x => x.UsuarioTipoId == usuarioTipoId);

            return await usuarioTipos.Select(x => new ExibirUsuarioTipoDTO
            {
                UsuarioTipoId = x.UsuarioTipoId,
                UsuarioTipoNome = x.UsuarioTipoNome,
                UsuarioTipoDataUltimaAtualizacao = x.UsuarioTipoDataUltimaAtualizacao
            })
                .ToListAsync();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
