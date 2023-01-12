using Repositorys.Context;
using Repositorys.Interfaces;
using System.Drawing;

namespace Repositorys.Repos
{
    public class FotoProdutoRepo : IFotoProdutoRepo
    {
        private readonly DesafioAprendizadoContext _context;
        public FotoProdutoRepo(DesafioAprendizadoContext context)
        {
            _context = context;
        }

        public string SalvarFotoProduto(string path)
        {
            Guid id = Guid.NewGuid();

            string newPath = Environment.GetEnvironmentVariable("pathFotoProduto");
            string filename = id.ToString() + ".jpg";
            string fullpath = Path.Combine(newPath, filename);

            File.Copy(@path, fullpath, true);
            return id.ToString();
        }
        public byte[] ObterFotosProdutos(string? fotoProdutoId)
        {
            Guid uuid = new Guid(fotoProdutoId);
            string path = Environment.GetEnvironmentVariable("pathFotoProduto");
            string filename = uuid.ToString() + ".jpg";
            string fullpath = Path.Combine(path, filename);

            MemoryStream ms = new();
            var foto = Image.FromFile(fullpath);
            foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
        public string AtualizarFotoProduto(string? fotoProdutoId, string path)
        {
            Guid uuid = new Guid(fotoProdutoId);

            string actualPath = Environment.GetEnvironmentVariable("pathFotoProduto");
            string filename = uuid.ToString() + ".jpg";
            string fullpath = Path.Combine(actualPath, filename);

            File.Copy(@path, @fullpath, true);
            return fotoProdutoId.ToString();
        }

        public void DeletarFotoProduto(string fotoProdutoId)
        {
            Guid uuid = new Guid(fotoProdutoId);
            string path = Environment.GetEnvironmentVariable("pathFotoProduto");
            string filename = uuid.ToString() + ".jpg";
            string fullpath = Path.Combine(path, filename);

            File.Delete(fullpath);
        }
    }
}
