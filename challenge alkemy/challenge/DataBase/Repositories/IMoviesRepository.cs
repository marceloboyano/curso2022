namespace DataBase.Repositories
{
    public interface IMoviesRepository : IGenericRepository<Movie>
    {
        public IEnumerable<Movie> GetMovieWithDetials();
        Task<Movie> GetByIdWithDetail(int id);
    }
}