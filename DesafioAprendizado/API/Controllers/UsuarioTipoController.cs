using BusinessLayer.DTO.UsuarioTipoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.UsuarioTipoDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class UsuarioTipoController : ControllerBase
    {
        private readonly IUsuarioTipoService _usuarioTipoService;
        public UsuarioTipoController()
        {
            _usuarioTipoService = new UsuarioTipoService();
        }

        /// <sumary>Adiciona um novo tipo de usuário</sumary>
        /// <response code="200"> Retorna que o usuário foi criado com sucesso</response>
        [HttpPost]
        public ActionResult Create([Bind(include: "UsuarioTipoDescricao")] CriarUsuarioTipoDTO criarUsuarioTipoDTO)
        {
            _usuarioTipoService.CriarUsuarioTipo(criarUsuarioTipoDTO);
            return Ok("Tipo de usuário criado com sucesso");
        }

        /// <sumary>Retorna todos os tipos de usuario</sumary>
        /// <response code="200"> Retorna uma lista com os tipos de usuário</response>
        [HttpGet]
        public ActionResult<List<ExibirUsuarioTipoDTO>> Get()
        {
            return Ok(_usuarioTipoService.ObterTodosUsuarioTipos().Result);
        }

        /// <sumary>Retorna um tipo de usuario por seu id</sumary>
        /// <response code="200"> Retorna o tipo de usuario pelo id informado</response>
        [HttpGet("id")]
        public ExibirUsuarioTipoDTO? Get([FromQuery] int id)
        {
            return _usuarioTipoService.ObterUsuarioTipoPorId(id);
        }

        /// <summary>Atualiza um tipo de usuário por seu id</summary>
        /// <response code="200">Retorna que o tipo de usuário foi atualizado com sucesso</response>
        [HttpPut]
        public ActionResult Edit([Bind(include: "UsuarioTipoId, UsuarioTipoDescricao, UsuarioTipoDeletado")] AtualizarUsuarioTipoDTO atualizarUsuarioTipoDTO)
        {
            _usuarioTipoService.AtualizarUsuarioTipo(atualizarUsuarioTipoDTO);
            return Ok("Tipo de usuário atualizado com sucesso");
        }

        /// <summary>Deleta um tipo de usuário por seu id</summary>
        /// <response code="200">Retorna que o tipo de usuário foi deletado com sucesso</response>
        [HttpDelete]
        public ActionResult Delete([FromQuery] int id)
        {
            _usuarioTipoService.DeletarUsuarioTipo(id);
            return Ok("Tipo de usuário deletado com sucesso");
        }
    }
}
