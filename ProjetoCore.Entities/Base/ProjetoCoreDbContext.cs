using Microsoft.EntityFrameworkCore;

namespace ProjetoCore.Entities.Base
{
    public class ProjetoCoreDbContext : DbContext
    {

        public ProjetoCoreDbContext(DbContextOptions<ProjetoCoreDbContext> options)
            : base(options)
        { }
        
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados {get; set;}
        public DbSet<Cidade> Cidades {get; set;}
    }
}
