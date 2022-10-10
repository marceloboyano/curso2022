using DataBase;
using System.ComponentModel.DataAnnotations;

namespace challenge.DTOs.Peliculas
{
    public class MoviesDto
    {
        public record MoviesForUpdateDTO(string? Title, DateTime? CreationDate, int? Qualification, string? Image);
        public class MoviesForShowDTO 
        {

            [Required(ErrorMessage = "El titulo de la pelicula es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Title { get; set; }

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }

            [Required(ErrorMessage = "La Fecha es un campo obligatorio.")]
            public DateTime CreationDate { get; set; }
          
        }
        public class MoviesForCreationDTO
        {
            [Required(ErrorMessage = "El titulo de la pelicula es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Title {get;set;}

            [Required(ErrorMessage = "La Fecha es un campo obligatorio.")]
            public DateTime CreationDate {get;set;}

            [Required(ErrorMessage = "La calificacion es un campo obligatorio.")]
            [Range(1, 5)]
            public int Rating {get;set;}

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }
        
        }
        public class MoviesForShowWithDetailsDTO
        {
            [Required(ErrorMessage = "El titulo de la pelicula es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Title { get; set; }

            [Required(ErrorMessage = "La Fecha es un campo obligatorio.")]
            public DateTime CreationDate { get; set; }

            [Required(ErrorMessage = "La calificacion es un campo obligatorio.")]
            [Range(1, 5)]
            public int Rating { get; set; }

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }

            public virtual ICollection<Gender> Genders { get; set; }      

            public virtual ICollection<Character> Characters { get; set; }

        }
         
    }
}
