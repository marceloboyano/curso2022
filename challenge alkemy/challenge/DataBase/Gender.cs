using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Gender : BusinessEntity
    {
        public override int Id { get => GenderID; }
        public Gender()
        {
            // Es buena practica inicilizar la colección de forma que no pueda haber Null reference execption en tiempo de ejecución
            Movies = new HashSet<Movie>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GenderID { get; set; }

        [Required(ErrorMessage = "El genero es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Name { get; set; }   
      
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
