namespace Silverback;

public class KafkaConfig
{
    public string BootstrapServers { get; set; } = "";
    public string Topic { get; set; } = "event-created";
    public string GroupId { get; set; } = "group1";
}