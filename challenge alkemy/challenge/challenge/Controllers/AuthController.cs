
using challenge.Services;
using Microsoft.AspNetCore.Mvc;

namespace challenge.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService _authService;
        private readonly IEmailService _emailService;

        public AuthController(IAuthService authService, IEmailService emailService)
        {

            _authService = authService;
            _emailService = emailService;
        }
        /// <summary>
        /// Crear cuenta Nueva
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password, string email)
        {
            var registerResponse = await _authService.RegisterUser(username, password, email);

            if (!registerResponse.Success)
            {
                return BadRequest(registerResponse.Message);
            }
            await _emailService.SendEmail(email, username);
            return Ok(registerResponse.Message);
        }

        /// <summary>
        /// Entrar
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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
