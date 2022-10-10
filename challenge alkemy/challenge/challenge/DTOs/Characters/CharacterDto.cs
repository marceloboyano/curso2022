using DataBase;
using System.ComponentModel.DataAnnotations;

namespace challenge.DTOs.Personajes
{

    public class CharacterDto
    {
        public record CharacterForUpdateDTO(string? Name, int? Age, decimal? Weight, string? History, string? Image);
        public class CharacterForShowDTO
        {
            [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Name { get; set; }
       

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }         
          
        }

        public class CharacterForCreationDTO
        {
            [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Name { get; set; }           

            [Required(ErrorMessage = "La edad es un campo obligatorio.")]
            [Range(0, 999)]
            public int Age { get; set; }
            public decimal Weight { get; set; }

            [Required(ErrorMessage = "La Historia es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string History { get; set; }

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }
        }

        public class CharacterForShowWithDetailsDTO
        {
            [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string Name { get; set; }

            [Required(ErrorMessage = "La edad es un campo obligatorio.")]
            [Range(0, 999)]
            public int Age { get; set; }
            public decimal Weight { get; set; }

            [Required(ErrorMessage = "La Historia es un campo obligatorio.")]
            [StringLength(255, MinimumLength = 1)]
            public string History { get; set; }

            [StringLength(255, MinimumLength = 1)]
            public string Image { get; set; }
            public virtual ICollection<Movie> Movies { get; set; }
        }
               
    }
}
