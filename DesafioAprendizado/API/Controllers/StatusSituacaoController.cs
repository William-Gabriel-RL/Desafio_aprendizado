using BusinessLayer.DTO.StatusSituacaoDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.StatusSituacaoDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class StatusSituacaoController : ControllerBase
    {
        private readonly IStatusSituacaoService _statusSituacaoService;
        public StatusSituacaoController()
        {
            _statusSituacaoService = new StatusSituacaoService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "StatusSituacaoNome")] CriarStatusSituacaoDTO criarStatusSituacaoDTO)
        {
            _statusSituacaoService.CriarStatusSituacao(criarStatusSituacaoDTO);
            return Ok("Status de situação criado com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirStatusSituacaoDTO>> Get([FromQuery] int? statusSituacaoId)
        {
            return Ok(_statusSituacaoService.ObterStatusSituacao(statusSituacaoId).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "StatusSituacaoId, StatusSituacaoNome, StatusSituacaoDeletado")] AtualizarStatusSituacaoDTO atualizarStatusSituacaoDTO)
        {
            _statusSituacaoService.AtualizarStatusSituacao(atualizarStatusSituacaoDTO);
            return Ok("Status da situação atualizado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int statusSituacaoId)
        {
            _statusSituacaoService.DeletarStatusSituacao(statusSituacaoId);
            return Ok("Status da situação deletado com sucesso");
        }
    }
}
