using System.ComponentModel.DataAnnotations;

namespace DataBase
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El usuario es un campo obligatorio.")]
        [StringLength(100, MinimumLength = 1)]
        public string Username { get; set; }
        [Required(ErrorMessage = "El password es un campo obligatorio.")]
        [StringLength(100, MinimumLength = 1)]
        public string Password { get; set; }
    }
}
