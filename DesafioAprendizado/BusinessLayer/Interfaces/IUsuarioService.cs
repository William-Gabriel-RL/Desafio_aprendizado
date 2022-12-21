using BusinessLayer.DTO.UsuarioDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioService
    {
        public void CriarUsuario(CriarUsuarioDTO usuario);
        public Usuario? ObterUsuarioPorMatricula(string UsuarioMatricula);
        public Task<IEnumerable<Usuario>> ObterTodosUsuarios();
        public void AtualizarUsuario(AtualizarUsuarioDTO usuario);
        public void DeletarUsuario(string UsuarioMatricula);
        public Usuario? Login(string usuarioMatricula, string usuarioSenha);
    }
}
