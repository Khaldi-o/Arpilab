using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GestionDePersonnes.Models
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()

             .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json");
            
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration
              ["ConnectionStrings:DefaultConnection"]);
        }

        public DbSet<Personne> Personnes { get; set; }

    }
}
