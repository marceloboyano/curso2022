using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class CharactersRepository : BaseRepository<Character>, ICharactersRepository
    {
        public CharactersRepository(DisneyContext context)
            : base(context)
        {

        }
        public async Task<Character?> GetByIdWithDetail(int id) => await _context.Characters
                .Include(p => p.Movies)
                .FirstOrDefaultAsync(m => m.CharacterID == id);
        public IEnumerable<Character> GetCharacterWithDetails() => _context.Characters
             .Include(p => p.Movies)            
             .AsEnumerable();

    }
}

