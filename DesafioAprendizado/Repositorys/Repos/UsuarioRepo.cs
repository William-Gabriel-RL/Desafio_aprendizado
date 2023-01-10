using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositorys.Context;
using Repositorys.DTO.UsuarioDTO;
using Repositorys.Interfaces;

namespace Repositorys.Repos
{
    public class UsuarioRepo : IUsuarioRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public UsuarioRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public void AtualizarUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void CriarUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void DeletarUsuario(string usuarioMatricula)
        {
            Usuario? usuario = _context.Usuarios.FirstOrDefault(x => x.UsuarioMatricula == usuarioMatricula);
            if (usuario != null)
            {
                if (usuario.UsuarioDeletado == false)
                {
                    usuario.UsuarioDeletado = true;
                    usuario.UsuarioDataUltimaAtualizacao = DateTime.Now;
                    _context.Update(usuario);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("Usuário já deletado");
                }
            }
            else
            {
                throw new Exception("Usuário não encontrado");
            }
        }

        public async Task<IEnumerable<ExibirUsuarioDTO>> ObterUsuarios(string? usuarioMatricula, int? usuarioTipo)
        {
            var usuarios = _context.Usuarios.Where(x => x.UsuarioDeletado == false);
            if (usuarioMatricula != null)
                usuarios = usuarios.Where(x => x.UsuarioMatricula == usuarioMatricula);
            if (usuarioTipo != null)
                usuarios = usuarios.Where(x => x.UsuarioTipoId== usuarioTipo);

            return await usuarios.Select(x => new ExibirUsuarioDTO
            {
                UsuarioMatricula = x.UsuarioMatricula,
                UsuarioNome = x.UsuarioNome,
                UsuarioTipo = x.Tipo.UsuarioTipoNome,
                UsuarioDataUltimaAtualizacao = x.UsuarioDataUltimaAtualizacao
            })
                .ToListAsync();
        }

        public Usuario? RecuperarUsuario(string UsuarioMatricula, string UsuarioSenha)
        {
            return _context.Usuarios.Where(x => x.UsuarioMatricula == UsuarioMatricula && x.UsuarioSenha == UsuarioSenha && x.UsuarioDeletado == false).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
