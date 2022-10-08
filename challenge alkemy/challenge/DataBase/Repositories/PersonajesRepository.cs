using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class PersonajesRepository : BaseRepository<Personaje>, IPersonajesRepository
    {
        public PersonajesRepository(DisneyContext context)
            : base(context)
        {

        }

        public IEnumerable<Personaje> GetPersonajeConDetalles() => _context.Personajes
             .Include(p => p.Peliculas)            
             .AsEnumerable();

    }
}

