using challenge.QueryFilters;
using challenge.Services;

using DataBase.Repositories;


namespace TestChallenge
{
    public class MovieTesting
    {

        private readonly IMovieService _controller;
        private readonly IMoviesRepository _repo;

        public MovieTesting(IMovieService controller, IMoviesRepository repo)
        {
            _controller = controller;
            _repo = repo;
        }

        //[Fact]
        //public async Task<IEnumerable<Pelicula>> Test()
        //{
        //   var testService = new 
        //}


    }
}