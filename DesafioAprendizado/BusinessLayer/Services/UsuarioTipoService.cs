using BusinessLayer.DTO.UsuarioTipoDTO;
using BusinessLayer.Interfaces;
using Entities.Models;
using Repositorys.Interfaces;
using Repositorys.Repos;
using Repositorys.Context;
using Microsoft.EntityFrameworkCore;
using Repositorys.DTO.UsuarioTipoDTO;

namespace BusinessLayer.Services
{
    public class UsuarioTipoService : IUsuarioTipoService
    {
        private readonly IUsuarioTipoRepo _usuarioTipoRepository;
        public UsuarioTipoService()
        {
            _usuarioTipoRepository = new UsuarioTipoRepo(new DesafioAprendizadoContext());
        }
        public void AtualizarUsuarioTipo(AtualizarUsuarioTipoDTO usuarioTipo)
        {
            UsuarioTipo usuarioAtualizado = new()
            {
                UsuarioTipoId = usuarioTipo.UsuarioTipoId,
                UsuarioTipoNome = usuarioTipo.UsuarioTipoNome,
                UsuarioTipoDeletado = usuarioTipo.UsuarioTipoDeletado,
                UsuarioTipoDataUltimaAtualizacao = DateTime.Now
            };
            _usuarioTipoRepository.AtualizarUsuarioTipo(usuarioAtualizado);
        }

        public void CriarUsuarioTipo(CriarUsuarioTipoDTO usuarioTipo)
        {
            UsuarioTipo novoUsuarioTipo = new()
            {
                UsuarioTipoNome = usuarioTipo.UsuarioTipoNome,
                UsuarioTipoDataUltimaAtualizacao = DateTime.Now
            };
            _usuarioTipoRepository.CriarUsuarioTipo(novoUsuarioTipo);
        }

        public void DeletarUsuarioTipo(int usuarioTipoId)
        {
            _usuarioTipoRepository.DeletarUsuarioTipo(usuarioTipoId);
        }

        public async Task<IEnumerable<ExibirUsuarioTipoDTO>> ObterTodosUsuarioTipos()
        {
            return await _usuarioTipoRepository.ObterTodosUsuarioTipos();
        }

        public ExibirUsuarioTipoDTO? ObterUsuarioTipoPorId(int usuarioTipoId)
        {
            return _usuarioTipoRepository.ObterUsuarioTipoPorId(usuarioTipoId);
        }
    }
}
