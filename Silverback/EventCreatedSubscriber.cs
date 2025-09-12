
namespace Silverback;

public class EventCreatedSubscriber
{
    public async Task OnMessageReceivedAsync(Event @event)
    {
        await Task.FromResult(0);
    }
}
