namespace Silverback;

public class KafkaConfig
{
    public string BootstrapServers { get; set; } = "localhost:9092";
    public string Topic { get; set; } = "event-created";
    public string GroupId { get; set; } = "group1";
}