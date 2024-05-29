using BdRenta.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace BdRenta.Modelos
{
    public class CatalogoDBContext : DbContext
    {
        public CatalogoDBContext(DbContextOptions<CatalogoDBContext> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }

        public DbSet<Automovil> Automoviles { get; set; }
    }
}