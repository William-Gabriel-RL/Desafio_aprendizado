using Entities.Models;
using Repositorys.DTO.UsuarioTipoDTO;

namespace Repositorys.Interfaces
{
    public interface IUsuarioTipoRepo
    {
        public void CriarUsuarioTipo(UsuarioTipo usuarioTipo);
        public Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterUsuarioTipos(int? UsuarioTipoId);
        public void AtualizarUsuarioTipo(UsuarioTipo usuarioTipo);
        public void DeletarUsuarioTipo(int UsuarioTipoId);
        public void Save();
    }
}
