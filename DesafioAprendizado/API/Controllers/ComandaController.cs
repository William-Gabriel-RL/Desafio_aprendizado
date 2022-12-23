using BusinessLayer.DTO.ComandaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComandaController : ControllerBase
    {
        private readonly IComandaService _comandaService;
        public ComandaController()
        {
            _comandaService = new ComandaService();
        }

        [HttpPost]
        public ActionResult Create([Bind(include: "AtendenteMatricula, MesaId")]CriarComandaDTO criarComandaDTO)
        {
            _comandaService.CriarComanda(criarComandaDTO);
            return Ok("Comanda criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<Comanda>> Get()
        {
            return Ok(_comandaService.ObterTodasComandas().Result);
        }

        [HttpGet("id")]
        public ActionResult<Comanda> Get(string comandaId)
        {
            return Ok(_comandaService.ObterComandaPorId(comandaId));
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "ComandaId, ComandaHoraAbertura, ComandaFinalizada, ComandaDeletado, AtendenteMatricula, MesaId, PagamentoId")]AtualizarComandaDTO atualizarComandaDTO)
        {
            _comandaService.AtualizarComanda(atualizarComandaDTO);
            return Ok("Comanda atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(string comandaId)
        {
            _comandaService.DeletarComanda(comandaId);
            return Ok("Comanda deletada com sucesso");
        }
    }
}
