using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class User
    {
        public int Id { get; set; }        
        [Required(ErrorMessage = "El usuario es un campo obligatorio y debe contener 5 letras como mínimo.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El {0} debe tener entre 5 y 50 caracteres")]
        public string Username { get; set; }
        [Required(ErrorMessage = "El password es un campo obligatorio y debe contener 6 letras como mínimo.")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "El {0} debe tener entre 6 y 150 caracteres")]
        public string Password { get; set; }
        [Required(ErrorMessage = "El email es un campo obligatorio.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El {0} debe tener entre 1  y 50 caracteres")]
        public string Email { get; set; }
    }
}
