using DataBase;

namespace challenge.Controllers
{
    public interface IAuthService
    {
        public Task<User> GetUserByPassword(string user, string password);
    }
}