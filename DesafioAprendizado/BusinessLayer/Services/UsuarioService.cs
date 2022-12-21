using BusinessLayer.DTO.UsuarioDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using System.Security.Cryptography;
using System.Text;
using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;

namespace BusinessLayer.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepo _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepo(new DesafioAprendizadoContext());
        }
        public void AtualizarUsuario(AtualizarUsuarioDTO usuario)
        {
            Usuario usuarioAtualizado = new()
            {
                UsuarioMatricula = usuario.UsuarioMatricula,
                UsuarioNome = usuario.UsuarioNome,
                UsuarioSenha = CriptoSenha(usuario.UsuarioSenha),
                UsuarioTipoId = usuario.UsuarioTipoId,
                UsuarioDeletado= usuario.UsuarioDeletado,
                UsuarioDataUltimaAtualizacao = DateTime.Now,
            };
            _usuarioRepository.AtualizarUsuario(usuarioAtualizado);
        }

        public void CriarUsuario(CriarUsuarioDTO usuario)
        {
            Usuario novoUsuario = new()
            {
                UsuarioMatricula = usuario.UsuarioMatricula,
                UsuarioNome = usuario.UsuarioNome,
                UsuarioSenha = CriptoSenha(usuario.UsuarioSenha),
                UsuarioTipoId = usuario.UsuarioTipoId,
                UsuarioDataUltimaAtualizacao = DateTime.Now,
            };
            _usuarioRepository.CriarUsuario(novoUsuario);
        }
        public void DeletarUsuario(string usuarioMatricula)
        {
            _usuarioRepository.DeletarUsuario(usuarioMatricula);
        }

        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            return await _usuarioRepository.ObterTodosUsuarios();
        }

        public Usuario? ObterUsuarioPorMatricula(string UsuarioMatricula)
        {
            return _usuarioRepository.ObterUsuarioPorMatricula(UsuarioMatricula);
        }

        public Usuario? Login(string usuarioMatricula, string usuarioSenha)
        {
            try
            {
                Usuario? usuario = _usuarioRepository.RecuperarUsuario(usuarioMatricula, CriptoSenha(usuarioSenha));
                if (usuario != null)
                {
                    return usuario;
                }
            }
            catch (Exception)
            {

                throw new Exception("Usuario ou senha inválidos");
            }
            return null;
        }
        public static string CriptoSenha(string senha)
        {
            using var sha256 = SHA256.Create();
            var hash = Encoding.UTF8.GetBytes(senha);
            var hashGerado = sha256.ComputeHash(hash);
            var hashGeradoString = Convert.ToBase64String(hashGerado);
            return hashGeradoString;
        }
    }
}
