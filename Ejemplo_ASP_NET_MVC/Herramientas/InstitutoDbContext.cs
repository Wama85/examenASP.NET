using Ejemplo_ASP_NET_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Ejemplo_ASP_NET_MVC.Herramientas
{
    public class InstitutoDbContext : DbContext
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                var config = builder.Build();
                optionsBuilder.UseLazyLoadingProxies().UseSqlServer(config["ConnectionStrings:miConexion"]);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Telefono>(entidad =>
                {
                    entidad.HasOne(t => t.estudiante).WithMany(est => est.telefonos)
                    .HasForeignKey(t => t.codigoEst).HasConstraintName("FK_Telefono_Estudiante");
                }
            );

        }
    }
}
