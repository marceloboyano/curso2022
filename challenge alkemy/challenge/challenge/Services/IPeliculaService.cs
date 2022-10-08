using challenge.DTOs.Peliculas;
using challenge.QueryFilters;
using DataBase;
using static challenge.DTOs.Peliculas.PeliculaDTO;

namespace challenge.Services
{
    public interface IPeliculaService
    {
        Task<IEnumerable<Pelicula>> GetPeliculas(PeliculasQueryFilters filters);      
        Task InsertPeliculas(PeliculaForCreationDTO pelicula);
        Task<bool> UpdatePeliculas(int id, PeliculaForUpdateDTO pelicula);
        Task<bool> DeletePeliculas(int id);
    }
}