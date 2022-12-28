using BusinessLayer.DTO.MesaDTO;
using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositorys.DTO.MesaDTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "1")]
    public class MesaController : ControllerBase
    {
        private readonly IMesaService _mesaService;
        public MesaController()
        {
            _mesaService = new MesaService();
        }

        [HttpPost]
        public ActionResult Create(CriarMesaDTO criarMesaDTO)
        {
            _mesaService.CriarMesa(criarMesaDTO);
            return Ok("Mesa criada com sucesso");
        }

        [HttpGet]
        public ActionResult<ICollection<ExibirMesaDTO>> Get(int? mesaId)
        {
            return Ok(_mesaService.ObterMesas(mesaId).Result);
        }

        [HttpPut]
        public ActionResult Edit([Bind(include: "MesaId, MesaOcupada, MesaDeletada")] AtualizarMesaDTO atualizarMesaDTO)
        {
            _mesaService.AtualizarMesa(atualizarMesaDTO);
            return Ok("Mesa atualizada com sucesso");
        }

        [HttpDelete]
        public ActionResult Delete(int MesaId)
        {
            _mesaService.DeletarMesa(MesaId);
            return Ok("Mesa deletada com sucesso");
        }
    }
}
