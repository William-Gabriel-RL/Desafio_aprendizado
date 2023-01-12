using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FotoProdutoController : ControllerBase
    {
        private readonly IFotoProdutoService _fotoProdutoService;
        public FotoProdutoController()
        {
            _fotoProdutoService = new FotoProdutoService();
        }

        [HttpPost]
        public ActionResult Post(string path)
        {
            return Ok($"Imagem salva sob o id: {_fotoProdutoService.SalvarFotoProduto(path)}");
        }

        [HttpGet]
        public IActionResult Get(string id)
        {
            var image = _fotoProdutoService.ObterFotosProdutos(id);
            return File(image, "image/jpg");
        }

        [HttpPut]
        public IActionResult Put(string id, string path)
        {
            return Ok($"Imagem com chave: {_fotoProdutoService.AtualizarFotoProduto(id, path)}, atualizada com sucesso");
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _fotoProdutoService.DeletarFotoProduto(id);
            return Ok("Imagem deletada com sucesso");
        }
    }
}
