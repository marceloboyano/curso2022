using DataBase.Repositories;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{ 
    public class Character : BusinessEntity
    {
        public override int Id { get => CharacterID; }
        public Character()
        {
            // Es buena practica inicilizar la colección de forma que no pueda haber Null reference execption en tiempo de ejecución
            Movies = new HashSet<Movie>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterID { get; set; }
        [Required(ErrorMessage = "El nombre es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string Name { get; set; }
        [Required(ErrorMessage = "La edad es un campo obligatorio.")]
        public int Age { get; set; }
        public decimal Weight { get; set; }
        [Required(ErrorMessage = "La Historia es un campo obligatorio.")]
        [StringLength(255, MinimumLength = 1)]
        public string History { get; set; }

        // Yo no haria required la imagen, ya que podría cargarse después       
        [StringLength(255, MinimumLength = 1)]
        public string Image { get; set; }
        //public byte[] Imagen { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
