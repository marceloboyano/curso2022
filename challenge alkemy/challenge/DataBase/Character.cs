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
          Movies = new HashSet<Movie>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CharacterID { get; set; }
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
