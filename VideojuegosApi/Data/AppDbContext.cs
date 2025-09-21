using Microsoft.EntityFrameworkCore;
using VideojuegosApi.Models;

namespace VideojuegosApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) : base(opts) { }
        public DbSet<Usuario> Usuarios { get; set; } = null!;
        public DbSet<Videojuego> Videojuegos { get; set; } = null!;
    }
}
