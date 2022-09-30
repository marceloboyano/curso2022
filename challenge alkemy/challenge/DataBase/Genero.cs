using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeneroID { get; set; }
        [Required(ErrorMessage = "El genero es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Nombre { get; set; }   
      
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
