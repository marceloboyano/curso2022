using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class CharactersRepository : BaseRepository<Character>, ICharactersRepository
    {
        public CharactersRepository(DisneyContext context)
            : base(context)
        {

        }

        public IEnumerable<Character> GetCharacterWithDetails() => _context.Characters
             .Include(p => p.Movies)            
             .AsEnumerable();

    }
}

