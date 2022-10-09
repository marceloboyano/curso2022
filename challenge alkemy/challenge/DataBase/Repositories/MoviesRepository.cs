using Microsoft.EntityFrameworkCore;

namespace DataBase.Repositories
{
    public class MoviesRepository : BaseRepository<Movie>, IMoviesRepository
    {
        public MoviesRepository(DisneyContext context)
            : base(context)
        {

        }

        public  IEnumerable<Movie> GetMovieWithDetials() =>  _context.Movies
                .Include(p => p.Genders)
                .Include(p => p.Characters)
                .AsEnumerable();
            
    }
}
