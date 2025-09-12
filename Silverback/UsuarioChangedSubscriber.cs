
namespace Silverback;

public class UsuarioChangedSubscriber
{
    public async Task OnUsuarioChangedAsync(UsuarioChanged message)
    {
        switch (message.Op)
        {
            case "c":
                //await _keycloakUserService.CreateUserIfNotExistsAsync(message);
                break;

            case "u":
                //await _keycloakUserService.UpdateUserIfChangedAsync(message);
                break;

            case "d":
                Console.WriteLine($"[Ignorado] Usu�rio {message.Username} marcado para exclus�o.");
                break;
        }
    }
}
