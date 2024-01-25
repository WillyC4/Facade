public interface IUserRegistrationService
{
    Task<bool> RegisterUser(string username, string password);
}
