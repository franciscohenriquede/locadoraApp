using Microsoft.EntityFrameworkCore;

namespace LocacaowebAplication.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options)
            : base(options)
        {

        }
        public DbSet<Cliente> Cliente{ get; set; } = null;


    }
}
