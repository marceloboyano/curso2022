using DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.DataProtection;
using AutoMapper;


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

            return await Task.FromResult(user);
        }
       
        public async Task<User?> GetUserByPassword(string username, string password)
        {


            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            //traemos el user  y comparamos los passwords
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
                return null;

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
                      
            var isValidUser = await IsUserValid(userName);
            if (!isValidUser.Success) return (isValidUser.Success, isValidUser.Message);


            var isValidEmail = await IsEmailValid(email);

            if (!isValidEmail.Success) return (isValidEmail.Success, isValidEmail.Message);


            // encryptamos el password antes de mandarlo a la base de datos
             password = BCrypt.Net.BCrypt.HashPassword(password);

            var userEntity = new User
            {
                Username = userName,
                Password = password,
                Email = email,
            };

            var result = _context.Users.Add(userEntity);
            var response = await _context.SaveChangesAsync() > 0;
            return (response, "Registro Exitoso");
        }


        public async Task<(bool Success, string Message)> IsUserValid(string userName)
        {
            // Validaciones de usuario
            if (string.IsNullOrEmpty(userName))
                return (false, "El username no puede estar vacio.");

            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToLower() == userName.ToLower());

            if (user is not null)
                return (false, "Ya existe un usuario registrado con ese nombre.");

            Regex regex = new("^[A-Za-z0-9ÑñÁáÉéÍíÓóÚúÜü\\s]{6,16}$");

            if (!regex.IsMatch(userName))
                return (false, "El Nombre de usuario puede contener solo letras y numeros entre 5-50 caracteres.");

            return (true, "Registro Exitoso");

        }



        public async Task<(bool Success, string Message)> IsEmailValid(string email)
        {
            //validaciones de mail

            if (string.IsNullOrEmpty(email))
                return (false, "El mail no puede estar vacio.");

            var mail = await _context.Users.FirstOrDefaultAsync(u => u.Email.ToLower() == email.ToLower());

            if (mail is not null)
                return (false, "Ya existe un usuario registrado con ese mail.");

            Regex regex = new("^[_a-z0-9A-Z]+(\\.[_a-z0-9A-Z]+)*@[a-zA-Z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-zA-Z]{2,15})$");
            if (!regex.IsMatch(email)) return (false, "No es un correo valido.");

            return (true, "Registro Exitoso");

        }
       
    }
}
