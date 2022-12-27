using BusinessLayer.DTO.UsuarioDTO;
using Entities.Models;
using Repositorys.DTO.UsuarioDTO;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioService
    {
        public void CriarUsuario(CriarUsuarioDTO usuario);
        public ExibirUsuarioDTO? ObterUsuarioPorMatricula(string UsuarioMatricula);
        public Task<IEnumerable<ExibirUsuarioDTO>> ObterTodosUsuarios();
        public void AtualizarUsuario(AtualizarUsuarioDTO usuario);
        public void DeletarUsuario(string UsuarioMatricula);
        public Usuario? Login(string usuarioMatricula, string usuarioSenha);
    }
}
