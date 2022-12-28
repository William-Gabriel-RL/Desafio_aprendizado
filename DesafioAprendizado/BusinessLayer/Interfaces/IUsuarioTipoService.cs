using BusinessLayer.DTO.UsuarioTipoDTO;
using Entities.Models;
using Repositorys.DTO.UsuarioTipoDTO;

namespace BusinessLayer.Interfaces
{
    public interface IUsuarioTipoService
    {
        public void CriarUsuarioTipo(CriarUsuarioTipoDTO usuarioTipo);
        public ExibirUsuarioTipoDTO? ObterUsuarioTipoPorId(int usuarioTipoId);
        public Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterTodosUsuarioTipos();
        public void AtualizarUsuarioTipo(AtualizarUsuarioTipoDTO usuarioTipo);
        public void DeletarUsuarioTipo(int usuarioTipoId);
    }
}
