public interface IPasswordRecoveryService
{
    Task<bool> RecoverPassword(string username);
}