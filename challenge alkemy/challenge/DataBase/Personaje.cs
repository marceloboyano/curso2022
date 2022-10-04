using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{ 
    public class Personaje : BusinessEntity
    {
        public override int Id { get => PersonajeID; }
        public Personaje()
        {
            // Es buena practica inicilizar la colección de forma que no pueda haber Null reference execption en tiempo de ejecución
            Peliculas = new HashSet<Pelicula>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonajeID { get; set; }
        [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La edad es un campo obligatorio.")]
        public int Edad { get; set; }
        public decimal Peso { get; set; }
        [Required(ErrorMessage = "La Historia es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Historia { get; set; }

        // Yo no haria required la imagen, ya que podría cargarse después       
        [StringLength(255, MinimumLength = 1)]
        public string Imagen { get; set; }
        //public byte[] Imagen { get; set; }
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
