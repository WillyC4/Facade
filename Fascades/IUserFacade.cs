public interface IUserFacade
{
    Task<bool> RegisterUser(string username, string password);
    Task<bool> LoginUser(string username, string password);
    Task<bool> RecoverPassword(string username);
}