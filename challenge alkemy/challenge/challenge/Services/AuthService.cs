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
    }
}
