namespace Silverback;

public record Event
{
    public string CalendarEmail { get; set; }
    public string CalendarId { get; set; }
    public string Title { get; set; }
    public string EventLink { get; set; }
    public DateTimeOffset Start { get; set; }
    public DateTimeOffset? End { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
    public string? ImageUrl { get; set; }
    public bool Public { get; set; } = true;
}
