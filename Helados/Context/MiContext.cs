using Helados.Models;
using Microsoft.EntityFrameworkCore;

namespace Helados.Context
{
    public class MiContext : DbContext
    {
        public MiContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }

    }
}
