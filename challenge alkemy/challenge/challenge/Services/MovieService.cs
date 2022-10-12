using AutoMapper;
using challenge.QueryFilters;
using DataBase;
using DataBase.Repositories;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace challenge.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMoviesRepository _repo;
        private readonly IMapper _mapper;

        public MovieService(IMoviesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

       
        public async Task<IEnumerable<Movie>> GetMovies(MovieQueryFilters filters)
        {

            
            var movies = _repo.GetMovieWithDetials();
        
           
            if(filters.Title != null)
            {
                movies = movies.Where(x=> x.Title.ToLower().Contains(filters.Title.ToLower()));
            }

            if (filters.GenderID != null)
            {
                movies = movies.Where(x => x.Genders.Any(g => g.GenderID == filters.GenderID));
            }

            if (filters.Order != null)
            {
                if (filters.Order.ToLower() == "asc")
                {
                    movies = movies.OrderBy(x => x.Title);
                }
            }

            if (filters.Order != null)
            {
                if (filters.Order.ToLower() == "desc")
                {
                    movies = movies.OrderByDescending(x => x.Title);
                }
            }

            return await Task.FromResult(movies);
        }
        public async Task InsertMovies(MoviesForCreationDTO movieDTO)
        {
            var movie = _mapper.Map<Movie>(movieDTO);

            await _repo.Create(movie);
        }

        public async Task<bool> UpdateMovies(int id, MoviesForUpdateDTO movieDto)
        {
            var movieEntity = await _repo.GetById(id);

            if(movieEntity is null)
                return false;

            if(movieDto.Title is not null)
            {
                movieEntity.Title = movieDto.Title;
            }

            if (movieDto.Image is not null)
            {
                movieEntity.Image = movieDto.Image;
            }

            if (movieDto.Qualification is not null)
            {
                movieEntity.Rating = movieDto.Qualification.Value;
            }

            if (movieDto.CreationDate is not null)
            {
                movieEntity.CreationDate = movieDto.CreationDate.Value;
            }

            return await _repo.Update(movieEntity);

        }


        public async Task<bool> DeleteMovies(int id)
        {

            return await _repo.Delete(id);

        }

        public async Task<MoviesForShowWithDetailsDTO> GetMovieById(int id)
        {
            var movie = await _repo.GetByIdWithDetail(id);

            var movieForShowWithDetails = _mapper.Map<MoviesForShowWithDetailsDTO>(movie);

            return movieForShowWithDetails;
        }
    }
}
     

