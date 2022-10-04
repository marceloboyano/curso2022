using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;

namespace challenge.Services
{
    public interface IPeliculaService
    {
        //Task<IEnumerable<PeliculaForShowDTO>> GetPeliculas();
        Task<IEnumerable<Pelicula>> GetPeliculas(PeliculasQueryFilters filters);
        Task<IEnumerable<PeliculaForShowDTO>> GetPeliculas();
    }
}