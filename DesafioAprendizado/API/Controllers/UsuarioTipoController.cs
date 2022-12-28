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

        [HttpPost]
        public ActionResult Create([Bind(include: "UsuarioTipoDescricao")] CriarUsuarioTipoDTO criarUsuarioTipoDTO)
        {
            _usuarioTipoService.CriarUsuarioTipo(criarUsuarioTipoDTO);
            return Ok("Tipo de usuário criado com sucesso");
        }

        [HttpGet]
        public ActionResult<List<ExibirUsuarioTipoDTO>> Get([FromQuery] int? usuarioTipoid)
        {
            return Ok(_usuarioTipoService.ObterUsuarioTipos(usuarioTipoid).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "UsuarioTipoId, UsuarioTipoDescricao, UsuarioTipoDeletado")] AtualizarUsuarioTipoDTO atualizarUsuarioTipoDTO)
        {
            _usuarioTipoService.AtualizarUsuarioTipo(atualizarUsuarioTipoDTO);
            return Ok("Tipo de usuário atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] int id)
        {
            _usuarioTipoService.DeletarUsuarioTipo(id);
            return Ok("Tipo de usuário deletado com sucesso");
        }
    }
}
