public class UserLoginService : IUserLoginService
{
    public async Task<bool> LoginUser(string username, string password)
    {
        // Lógica de inicio de sesión aquí
        // Ejemplo simple: Verificar si el usuario y la contraseña coinciden en una base de datos
        if (username == "usuario" && password == "contraseña")
        {
            return true;
        }

        return false;
    }
}

