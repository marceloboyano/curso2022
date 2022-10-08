using DataBase;

namespace challenge.Services
{
    public interface IAuthService
    {
        public Task<User> GetUserByPassword(string user, string password);
    }
}