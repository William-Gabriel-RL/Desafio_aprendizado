using BusinessLayer.DTO.UsuarioTipoDTO;
using Entities.Models;
using Repositorys.DTO.UsuarioTipoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioTipoService
    {
        public void CriarUsuarioTipo(CriarUsuarioTipoDTO usuarioTipo);
        public Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterUsuarioTipos(int? usuarioTipoId);
        public void AtualizarUsuarioTipo(AtualizarUsuarioTipoDTO usuarioTipo);
        public void DeletarUsuarioTipo(int usuarioTipoId);
    }
}
