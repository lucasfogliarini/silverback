namespace Silverback;

public class KafkaConfig
{
    public required string BootstrapServers { get; set; }
    public required string Topic { get; set; }
    public required string ConsumerGroupId { get; set; }
}