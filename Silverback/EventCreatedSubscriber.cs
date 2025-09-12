
namespace Silverback;

public class EventCreatedSubscriber(ILogger<EventCreatedSubscriber> logger)
{
    public async Task OnMessageReceivedAsync(Event @event)
    {
        logger.LogInformation("Event received: {Event}", @event);
    }
}
