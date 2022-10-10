using DataBase;
using System.ComponentModel.DataAnnotations;

namespace challenge.DTOs.Peliculas
{
    public class MoviesDto
    {
        public record MoviesForShowDTO(string Image, string Title, DateTime CreationDate);
        public record MoviesForUpdateDTO(string? Title, DateTime? CreationDate, int? Qualification, string? Image);
        public class MoviesForCreationDTO
        {
            [Required]
            public string Title {get;set;}
            public DateTime CreationDate {get;set;}
            
            [Range(1, 5)]
            public int Qualification {get;set;}
            public string Image { get; set; }
        
        }
        public record MoviesForShowWithDetailsDTO(string Title, DateTime CreationDate, int Qualification, string Image, ICollection<Character> Characters, ICollection<Gender> Genders);      
    }
}
