using Entities.Models;
using Repositorys.DTO.UsuarioDTO;

namespace Repositorys.Interfaces
{
    public interface IUsuarioRepo
    {
        public void CriarUsuario(Usuario usuario);
        public ExibirUsuarioDTO? ObterUsuarioPorMatricula(string UsuarioMatricula);
        public Task<IEnumerable<ExibirUsuarioDTO>> ObterTodosUsuarios();
        public void AtualizarUsuario(Usuario usuario);
        public void DeletarUsuario(string usuarioMatricula);
        public Usuario? RecuperarUsuario(string UsuarioMatricula, string UsuarioSenha);
        public void Save();
    }
}
