using DataBase;

namespace challenge.DTOs.Peliculas
{
    public class MoviesDto
    {
        public record MoviesForShowDTO(string Image, string Title, DateTime CreationDate);
        public record MoviesForUpdateDTO(string? Title, DateTime? CreationDate, int? Qualification, string? Image);
        public record MoviesForCreationDTO(string Title, DateTime CreationDate, int Qualification, string Image);
        public record MoviesForShowWithDetailsDTO(string Title, DateTime CreationDate, int Qualification, string Image, ICollection<Character> Characters, ICollection<Gender> Genders);      
    }
}
