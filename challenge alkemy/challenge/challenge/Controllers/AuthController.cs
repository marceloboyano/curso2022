
using challenge.Services;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
           
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {

            return Ok("Registro Exitoso");
        }
        
        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Validar si usuario y contraseña son correctos
            var user = await _authService.GetUserByPassword(username, password);

            if(user is null)
            {
                return NotFound("Las credenciales son incorrectas");
            }

            // Crear token
            var token =  _authService.CreateToken(user);

            return Ok("Bearer "+token);
        }

        
    }
}
