using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IUsuarioRepo
    {
        public void CriarUsuario(Usuario usuario);
        public Usuario? ObterUsuarioPorMatricula(string UsuarioMatricula);
        public Task<IEnumerable<Usuario>> ObterTodosUsuarios();
        public void AtualizarUsuario(Usuario usuario);
        public void DeletarUsuario(string usuarioMatricula);
        public Usuario? RecuperarUsuario(string UsuarioMatricula, string UsuarioSenha);
        public void Save();
    }
}
