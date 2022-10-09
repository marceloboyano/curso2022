using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class User
    {
        public int Id { get; set; }        
        [Required(ErrorMessage = "El usuario es un campo obligatorio y debe contener 5 letras como mínimo.")]
        [StringLength(50, MinimumLength = 5)]
        public string Username { get; set; }
        [Required(ErrorMessage = "El password es un campo obligatorio y debe contener 6 letras como mínimo.")]
        [StringLength(50, MinimumLength = 6)]
        public string Password { get; set; }
        [Required(ErrorMessage = "El email es un campo obligatorio.")]
        [StringLength(50, MinimumLength = 5)]
        public string Email { get; set; }
    }
}
