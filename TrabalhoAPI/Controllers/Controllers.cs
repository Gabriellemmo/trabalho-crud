using Microsoft.AspNetCore.Mvc;
using TrabalhoAPI.Data;
using TrabalhoAPI.Models;

namespace TrabalhoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly Context _context;

        public ProdutoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Produtos.ToList());
        }

        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Produto produto)
        {
            var p = _context.Produtos.Find(id);
            if (p == null) return NotFound();

            p.Nome = produto.Nome;
            p.Preco = produto.Preco;

            _context.SaveChanges();
            return Ok(p);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var p = _context.Produtos.Find(id);
            if (p == null) return NotFound();

            _context.Produtos.Remove(p);
            _context.SaveChanges();

            return Ok();
        }
    }
}