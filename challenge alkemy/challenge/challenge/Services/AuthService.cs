using challenge.Controllers;
using DataBase;
using Microsoft.EntityFrameworkCore;

namespace challenge.Services
{
    public class AuthService : IAuthService
    {
        private readonly DisneyContext _context;

        public AuthService(DisneyContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByPassword(string username, string password)
        {
            //var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if(username == "marcelo" && password == "12345")
            {
            }

            return new User()
            {
                Username = "marcelo",
                Password = "123456"
            };
        }
    }
}
