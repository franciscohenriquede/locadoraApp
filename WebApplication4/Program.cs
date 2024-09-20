
using Microsoft.EntityFrameworkCore;
using LocacaowebAplication.Models;
namespace WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<LocadoraContext>(opt => opt.UseInMemoryDatabase("Locadora"));
            builder.Services.AddDbContext<VeiculoContext>(opt => opt.UseInMemoryDatabase("Locadora"));
            builder.Services.AddDbContext<ClientContext>(opt => opt.UseInMemoryDatabase("Locadora"));
            builder.Services.AddDbContext<FuncionarioContext>(opt => opt.UseInMemoryDatabase("Locadora"));
            builder.Services.AddDbContext<PagamentoContext>(opt => opt.UseInMemoryDatabase("Locadora"));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
