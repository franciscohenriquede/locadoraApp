using Microsoft.EntityFrameworkCore;

namespace LocacaowebAplication.Models
{
    public class VeiculoContext : DbContext
    {
        public VeiculoContext(DbContextOptions<VeiculoContext> options)
            : base(options)
        {

        }
                public DbSet<Veiculo> Veiculo { get; set; } = null;


    }
    }


