using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;
using static challenge.DTOs.Peliculas.MoviesDto;

namespace challenge.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<Movie>> GetMovies(MovieQueryFilters filters);      
        Task InsertMovies(MoviesForCreationDTO movie);
        Task<bool> UpdateMovies(int id, MoviesForUpdateDTO movie);
        Task<bool> DeleteMovies(int id);
        Task<MoviesForShowWithDetailsDTO> GetMovieById(int id);
    }
}