using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<veiculo> Veiculos { get; set; }

        // Aqui você pode adicionar DbSet<T> para suas entidades, por exemplo:
        // public DbSet<Produto> Produtos { get; set; }
    }
}