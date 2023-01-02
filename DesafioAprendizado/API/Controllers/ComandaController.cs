using BusinessLayer.DTO.ComandaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.ComandaDTO;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1, 2")]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;
        public ComandaController()
        {
            _comandaService = new ComandaService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "AtendenteMatricula, MesaId")] CriarComandaDTO criarComandaDTO)
        {
            var matricula = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _comandaService.CriarComanda(criarComandaDTO, matricula);
            return Ok("Comanda criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirComandaDTO>> Get(string? comandaId, bool? finalizada, string? usuarioMatricula, int? mesaId, int? ano, int? mes, int? dia)
        {
            return Ok(_comandaService.ObterComandas(comandaId, finalizada, usuarioMatricula, mesaId, ano, mes, dia).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ComandaId, ComandaHoraAbertura, ComandaFinalizada, ComandaDeletado, AtendenteMatricula, MesaId, PagamentoId")] AtualizarComandaDTO atualizarComandaDTO)
        {
            _comandaService.AtualizarComanda(atualizarComandaDTO);
            return Ok("Comanda atualizada com sucesso");
        }

        [HttpPut("id")]
        public ActionResult ObterTotal(string comandaId)
        {
            _comandaService.ObterTotal(comandaId);
            return Ok("Total da comanda foi calculado com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(string comandaId)
        {
            _comandaService.DeletarComanda(comandaId);
            return Ok("Comanda deletada com sucesso");
        }
    }
}
