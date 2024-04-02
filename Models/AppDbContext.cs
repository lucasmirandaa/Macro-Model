using Microsoft.EntityFrameworkCore;

namespace Macro_Model.Models
{
    public class AppDbContext:DbContext
    {
        public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}
