using Microsoft.EntityFrameworkCore;

namespace LocacaowebAplication.Models
{
    public class PagamentoContext : DbContext
    {
        public PagamentoContext(DbContextOptions<PagamentoContext> options)
          : base(options)
        {






        }


        public DbSet<Pagamento> Pagamento { get; set; } = null;

    }
}