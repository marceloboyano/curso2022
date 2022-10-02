using challenge.DTOs.Peliculas;

namespace challenge.Services
{
    public interface IPeliculaService
    {
        Task<IEnumerable<PeliculaForShowDTO>> GetPeliculas();
    }
}