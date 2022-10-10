using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Movie : BusinessEntity
    {
        public override int Id { get => MoviesID; }

        public Movie()
        {
            Characters = new HashSet<Character>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MoviesID { get; set; }
        [Required(ErrorMessage = "El titulo de la pelicula es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Title { get; set; }
        [Required(ErrorMessage = "La Fecha es un campo obligatorio.")]
        public DateTime CreationDate { get; set; }
        [Required(ErrorMessage = "La calificacion es un campo obligatorio.")]
        [Range(1, 5)]
        public int Rating { get; set; }
        public virtual ICollection<Gender> Genders { get; set; }

        [StringLength(255, MinimumLength = 1)]
        public string Image { get; set; }                         
      
        public virtual ICollection<Character> Characters { get; set; }
    }
}
