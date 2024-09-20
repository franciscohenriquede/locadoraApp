using Microsoft.EntityFrameworkCore;
namespace LocacaowebAplication.Models
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options)
          : base(options)
        {


        }

        public DbSet<Locadora> Locadora { get; set; } = null;
        
        }

    }
    