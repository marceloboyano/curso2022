using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;

namespace challenge.Services
{
    public interface IPeliculaService
    {
        Task<IEnumerable<Pelicula>> GetPeliculas(PeliculasQueryFilters filters);
        Task<IEnumerable<Pelicula>> GetPeliculas();
        Task InsertPeliculas(Pelicula pelicula);
        Task<bool> UpdatePeliculas(Pelicula pelicula);
        Task<bool> DeletePeliculas(int id);
    }
}