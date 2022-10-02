using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Pelicula : BusinessEntity
    {
        public override int Id { get => PeliculaID; }

        public Pelicula()
        {
            Personajes = new HashSet<Personaje>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PeliculaID { get; set; }
        [Required(ErrorMessage = "El titulo de la pelicula es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "La Fecha es un campo obligatorio.")]
        public DateTime FechaCreacion { get; set; }
        [Required(ErrorMessage = "La calificacion es un campo obligatorio.")]
        [StringLength(5, MinimumLength = 1)]
        public int Calificacion { get; set; }
        public virtual ICollection<Genero> Generos { get; set; }

        // Yo no haria required la imagen, ya que podría cargarse después
        [Required(ErrorMessage = "La imagen es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Imagen { get; set; }
        //public byte[] Imagen { get; set; }                  
      
        public virtual ICollection<Personaje> Personajes { get; set; }
    }
}
