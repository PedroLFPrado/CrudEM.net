using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

// Ex de TOCC8 feito por Gustavo Camargo e Pedro Lemos

namespace CrudEMnet.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("conexao");
            optionsBuilder.UseNpgsql(connectionString);
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
