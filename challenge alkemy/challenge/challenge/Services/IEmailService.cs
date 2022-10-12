namespace challenge.Services
{
    public interface IEmailService
    {
        public Task SendEmail(string email, string username);
    }
}
