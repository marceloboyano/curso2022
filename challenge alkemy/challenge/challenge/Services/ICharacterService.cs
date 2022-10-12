
using challenge.QueryFilters;
using DataBase;
using static challenge.DTOs.Personajes.CharacterDto;

namespace challenge.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetCharacters(CharacterQueryFilter filters);
        Task<CharacterForShowWithDetailsDTO> GetCharacterById(int id);
        Task InsertCharacters(CharacterForCreationDTO character);
        Task<bool> UpdateCharacters(int id, CharacterForUpdateDTO character);   
        Task<bool> DeleteCharacters(int id);
    }
}