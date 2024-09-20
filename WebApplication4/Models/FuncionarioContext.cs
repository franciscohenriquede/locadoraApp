using Microsoft.EntityFrameworkCore;

namespace LocacaowebAplication.Models
{

    public class FuncionarioContext : DbContext
    {
        public FuncionarioContext(DbContextOptions<FuncionarioContext> options)
                : base(options)
        {
        }
      public DbSet<Funcionario> Funcionarios { get; set; } = null;


    }
}



        