using Microsoft.EntityFrameworkCore;
using TrabalhoAPI.Models;

namespace TrabalhoAPI.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) {}

        public DbSet<Produto> Produtos { get; set; }
    }
}