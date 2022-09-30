using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
