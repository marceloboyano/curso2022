using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class MoviesRepository : BaseRepository<Movie>, IMoviesRepository
    {
        public MoviesRepository(DisneyContext context)
            : base(context)
        {

        }

        public async Task<Movie?> GetByIdWithDetail(int id) => await _context.Movies
                .Include(p => p.Genders)
                .Include(p => p.Characters)
                .FirstOrDefaultAsync(m  => m.MoviesID == id);

        public  IEnumerable<Movie> GetMovieWithDetials() =>  _context.Movies
                .Include(p => p.Genders)
                .Include(p => p.Characters)
                .AsEnumerable();
            
    }
}
