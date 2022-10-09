using DataBase;

namespace challenge.DTOs.Personajes
{

    public class CharacterDto
    {
        public record CharacterForShowDTO(string Name, string Image);
        public record CharacterForUpdateDTO(string? Name, int? Age, decimal? Weight, string? History, string? Image);
        public record CharacterForCreationDTO(string Name, int Age, decimal Weight, string History, string Image);
        public record CharacterForShowWithDetailsDTO(string Name, int Age, decimal Weight, string History, string Image, ICollection<Movie> Movies);     
    }
}
