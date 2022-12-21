using Entities.Models;

namespace Repositorys.Interfaces
{
    public interface IUsuarioTipoRepo
    {
        public void CriarUsuarioTipo(UsuarioTipo usuarioTipo);
        public UsuarioTipo? ObterUsuarioTipoPorId(int UsuarioTipoId);
        public Task<IEnumerable<UsuarioTipo>> ObterTodosUsuarioTipos();
        public void AtualizarUsuarioTipo(UsuarioTipo usuarioTipo);
        public void DeletarUsuarioTipo(int UsuarioTipoId);
        public void Save();
    }
}
