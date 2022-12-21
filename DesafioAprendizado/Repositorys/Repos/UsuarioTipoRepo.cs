using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
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
                if(usuarioTipo.UsuarioTipoDeletado == false)
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

        public async Task<IEnumerable<UsuarioTipo>> ObterTodosUsuarioTipos()
        {
            return await _context.UsuarioTipos.Take(10).ToListAsync();
        }

        public UsuarioTipo? ObterUsuarioTipoPorId(int usuarioTipoId)
        {
            return _context.UsuarioTipos.Find(usuarioTipoId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
