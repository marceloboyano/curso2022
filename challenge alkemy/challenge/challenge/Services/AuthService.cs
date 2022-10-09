using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

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

        public async Task<(bool Success, string Message)> RegisterUser(string userName, string password, string email)
        {
           
            // Validaciones de usuario

            if (string.IsNullOrEmpty(userName)) return (false, "El username no puede estar vacio.");

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == userName.ToLower());

            if (user is not null) return (false, "Ya existe un usuario registrado con ese nombre.");

            Regex regex = new Regex("^[A-Za-zÑñÁáÉéÍíÓóÚúÜü\\s]+$");
            if (!regex.IsMatch(userName)) return (false, "El Nombre sólo acepta letras y espacios en blanco.");

            //validaciones de email

            if (string.IsNullOrEmpty(email)) return (false, "El email no puede estar vacio.");
            
            var mail = await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());

            if (mail is not null) return (false, "Ya existe un usuario registrado con ese email."); 

            regex = new Regex("^[_a-z0-9A-Z]+(\\.[_a-z0-9A-Z]+)*@[a-zA-Z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-zA-Z]{2,15})$");
            if (!regex.IsMatch(email)) return (false, "No es un correo valido.");

         
        


            var userEntity = new User
            {
                Username = userName,
                Password = password,
                Email = email,
            };

            var result = _context.Users.Add(userEntity);
            return (await _context.SaveChangesAsync() > 0, null);
        }

        public async Task SendEmail(string email, string userName)
        {                 


           // var apiKey  = Environment.GetEnvironmentVariable("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");
            var client = new SendGridClient("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");
            var from = new EmailAddress(email, userName);
            var subject = "Registro exitoso!!";
            var to = new EmailAddress(email, userName);
            var plainTextContent = "Bienvenido!! Gracias por registrate";
            var htmlContent = "<strong>Hola, Gracias por Registrarte!!!</strong> ";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            await client.SendEmailAsync(msg);    

        }
    }
}
