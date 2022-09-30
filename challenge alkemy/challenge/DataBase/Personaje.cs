using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{ 
    public class Personaje
    {
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
        [Required(ErrorMessage = "La imagen es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Imagen { get; set; }
        //public byte[] Imagen { get; set; }
        public virtual ICollection<Pelicula> Peliculas { get; set; }
    }
}
