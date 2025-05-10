using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ECARTemplate.Models;

namespace ECARTemplate.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioTI> UsuariosTI { get; set; }
        public DbSet<Credencial> Credenciales { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración del índice único para CodigoEquipo en la tabla Equipos
            modelBuilder.Entity<Equipo>()
                .HasIndex(e => e.CodigoEquipo)
                .IsUnique();

            // Configuración del índice único para CodigoUsuarioEcar en la tabla Usuarios
            modelBuilder.Entity<Usuario>()
                .HasIndex(u => u.CodigoUsuarioEcar)
                .IsUnique();
        }
    }
}