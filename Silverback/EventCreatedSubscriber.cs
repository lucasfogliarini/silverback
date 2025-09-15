
namespace Silverback;

public class EventCreatedSubscriber(ILogger<EventCreatedSubscriber> logger)
{
    public async Task OnMessageReceivedAsync(EventCreated eventCreated)
    {
        logger.LogInformation("Evento recebido: {EventCreated}", eventCreated);
    }
}
