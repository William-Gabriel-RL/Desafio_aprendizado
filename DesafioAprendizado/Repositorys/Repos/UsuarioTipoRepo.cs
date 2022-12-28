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

        public async Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterTodosUsuarioTipos()
        {
            return await _context.UsuarioTipos
                .Where(x => x.UsuarioTipoDeletado == false)
                .Select(x => new ExibirUsuarioTipoDTO
                {
                    UsuarioTipoId = x.UsuarioTipoId,
                    UsuarioTipoNome = x.UsuarioTipoNome,
                    UsuarioTipoDataUltimaAtualizacao = x.UsuarioTipoDataUltimaAtualizacao
                })
                .ToListAsync();
        }

        public ExibirUsuarioTipoDTO? ObterUsuarioTipoPorId(int usuarioTipoId)
        {
            return _context.UsuarioTipos
                .Where(x => x.UsuarioTipoDeletado == false)
                .Select(x => new ExibirUsuarioTipoDTO
                {
                    UsuarioTipoId = x.UsuarioTipoId,
                    UsuarioTipoNome = x.UsuarioTipoNome,
                    UsuarioTipoDataUltimaAtualizacao = x.UsuarioTipoDataUltimaAtualizacao
                })
                .FirstOrDefault(x => x.UsuarioTipoId == usuarioTipoId);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
