using API.Service.Token;
using BusinessLayer.DTO.UsuarioDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.UsuarioDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }

        /// <summary>Cria um novo usuário</summary>
        /// <response code="200">Retorna que o novo usuário foi criado com sucesso</response>
        [HttpPost]
        public ActionResult Create([Bind(include: "UsuarioMatricula, UsuarioNome, UsuarioSenha, UsuarioTipoId")] CriarUsuarioDTO criarUsuarioDTO)
        {
            _usuarioService.CriarUsuario(criarUsuarioDTO);
            return Ok("Usuário criado com sucesso");
        }

        [HttpGet("UsuarioId")]
        public ExibirUsuarioDTO? Get([FromQuery] string UsuarioId)
        {
            ExibirUsuarioDTO? usuario = _usuarioService.ObterUsuarioPorMatricula(UsuarioId);
            return usuario;
        }

        [HttpGet]
        public ActionResult<List<ExibirUsuarioDTO>> GetAll()
        {
            return Ok(_usuarioService.ObterTodosUsuarios().Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "UsuarioMatricula, UsuarioNome, UsuarioSenha, UsuarioTipoId, UsuarioDeletado")] AtualizarUsuarioDTO atualizarUsuarioDTO)
        {
            _usuarioService.AtualizarUsuario(atualizarUsuarioDTO);
            return Ok("Usuário atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete([FromQuery] string UsuarioId)
        {
            _usuarioService.DeletarUsuario(UsuarioId);
            return Ok("Usuário deletado com sucesso");
        }

        [HttpPost("Autenticação")]
        public ActionResult<string> Authenticate([FromBody] AutenticarUsuarioDTO usuario)
        {
            var usuarioAutenticado = _usuarioService.Login(usuario.UsuarioMatricula, usuario.UsuarioSenha);
            if (usuarioAutenticado != null)
            {
                var token = TokenService.GenerateToken(usuarioAutenticado);
                return Ok(token);
            }
            return NotFound("Usuário e/ou senha inserido(s) incorretamente");
        }
    }
}
