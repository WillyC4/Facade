public class UserFacade : IUserFacade
{
    private readonly IUserRegistrationService _registrationService;
    private readonly IUserLoginService _loginService;
    private readonly IPasswordRecoveryService _recoveryService;

    public UserFacade(
        IUserRegistrationService registrationService,
        IUserLoginService loginService,
        IPasswordRecoveryService recoveryService)
    {
        _registrationService = registrationService;
        _loginService = loginService;
        _recoveryService = recoveryService;
    }

    public async Task<bool> RegisterUser(string username, string password)
    {
        return await _registrationService.RegisterUser(username, password);
    }

    public async Task<bool> LoginUser(string username, string password)
    {
        return await _loginService.LoginUser(username, password);
    }

    public async Task<bool> RecoverPassword(string username)
    {
        return await _recoveryService.RecoverPassword(username);
    }
}
