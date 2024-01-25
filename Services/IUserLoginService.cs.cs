public interface IUserLoginService
{
    Task<bool> LoginUser(string username, string password);
}

