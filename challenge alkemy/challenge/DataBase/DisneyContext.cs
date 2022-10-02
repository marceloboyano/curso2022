using Microsoft.EntityFrameworkCore;

// Remover using innecesarios tocando Ctrl K + E

namespace DataBase
{
    public class DisneyContext : DbContext
    {
        public DisneyContext(DbContextOptions<DisneyContext> options)
             : base(options)
        {

        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

    }

}
