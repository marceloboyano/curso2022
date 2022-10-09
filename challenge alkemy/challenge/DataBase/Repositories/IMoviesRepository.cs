namespace DataBase.Repositories
{
    public interface IMoviesRepository : IGenericRepository<Movie>
    {
        public IEnumerable<Movie> GetMovieWithDetials();
    }
}