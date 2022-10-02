using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Genero : BusinessEntity
    {
        public override int Id { get => GeneroID; }
        public Genero()
        {
            // Es buena practica inicilizar la colección de forma que no pueda haber Null reference execption en tiempo de ejecución
            Peliculas = new HashSet<Pelicula>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GeneroID { get; set; }

        [Required(ErrorMessage = "El genero es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Nombre { get; set; }   
      
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
