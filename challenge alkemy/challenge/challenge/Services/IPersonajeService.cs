
using challenge.QueryFilters;
using DataBase;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Services
{
    public interface IPersonajeService
    {
        Task<IEnumerable<Personaje>> GetPersonajes(PersonajeQueryFilter filters);
        Task<IEnumerable<Personaje>> GetPersonajes();
        Task InsertPersonajes(Personaje personaje);
        Task<bool>  UpdatePersonajes(Personaje personaje);
        Task<bool> DeletePersonajes(int id);
    }
}