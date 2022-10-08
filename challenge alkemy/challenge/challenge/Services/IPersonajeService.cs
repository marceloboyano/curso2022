
using challenge.QueryFilters;
using DataBase;
using static challenge.DTOs.Personajes.PersonajeDto;

namespace challenge.Services
{
    public interface IPersonajeService
    {
        Task<IEnumerable<Personaje>> GetPersonajes(PersonajeQueryFilter filters);     
        Task InsertPersonajes(PersonajeForCreationDTO personaje);
        Task<bool> UpdatePersonajes(int id, PersonajeForUpdateDTO personaje);   
        Task<bool> DeletePersonajes(int id);
    }
}