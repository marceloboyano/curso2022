using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace challenge.Services
{
    public class AuthService : IAuthService
    {
        private readonly DisneyContext _context;
        private readonly IConfiguration _config;

        public AuthService(IConfiguration config, DisneyContext context)
        {
            _context = context;
            _config = config;
        }

        public async Task<User> GetUserById(int id)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == id);

            return user;
        }

        public async Task<User> GetUserByPassword(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            return user;
        }

        public string CreateToken(User user)
        {
            var issuer = _config["Jwt:Issuer"];
            var audience = _config["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("sub", user.Id.ToString()),
                    new Claim("name", user.Username)
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
            };


            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            var stringToken = tokenHandler.WriteToken(token);

            return stringToken;
        }

        public async Task<(bool Success, string Message)> RegisterUser(string username, string password)
        {
            // Valido que el username no llegue vacio
            if (string.IsNullOrEmpty(username))
                return (false, "el username no puede estar vacio");

            // Valido que el username sea único
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == username.ToLower());

            if (user is not null)
                return (false, "ya existe un usuario registrado con ese nombre");

            var userEntity = new User
            {
                Username = username,
                Password = password,
            };

            var result = _context.Users.Add(userEntity);
            return (await _context.SaveChangesAsync() > 0, null);
        }
    }
}
