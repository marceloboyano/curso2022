using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class PeliculasRepository : BaseRepository<Pelicula>, IPeliculasRepository
    {
        public PeliculasRepository(DisneyContext context)
            : base(context)
        {

        }

        public  IEnumerable<Pelicula> GetPeliculaConDetalles() =>  _context.Peliculas
                .Include(p => p.Generos)
                .Include(p => p.Personajes)
                .AsEnumerable();
            
    }
}
