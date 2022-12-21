using BusinessLayer.DTO.UsuarioTipoDTO;
using Entities.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioTipoService
    {
        public void CriarUsuarioTipo(CriarUsuarioTipoDTO usuarioTipo);
        public UsuarioTipo? ObterUsuarioTipoPorId(int usuarioTipoId);
        public Task<IEnumerable<UsuarioTipo>> ObterTodosUsuarioTipos();
        public void AtualizarUsuarioTipo(AtualizarUsuarioTipoDTO usuarioTipo);
        public void DeletarUsuarioTipo(int usuarioTipoId);
    }
}
