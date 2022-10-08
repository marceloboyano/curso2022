
using challenge.Services;
using Microsoft.AspNetCore.Mvc;

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
            var registerResponse = await _authService.RegisterUser(username, password);

            if (!registerResponse.Success)
            {
                return BadRequest(registerResponse.Message);
            }

            return Ok("Registro Exitoso");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Validar si usuario y contraseña son correctos
            var user = await _authService.GetUserByPassword(username, password);

            if (user is null)
            {
                return NotFound("Las credenciales son incorrectas");
            }

            // Crear token
            var token = _authService.CreateToken(user);

            return Ok(token);
        }


    }
}
