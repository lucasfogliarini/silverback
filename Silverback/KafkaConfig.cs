using System.ComponentModel.DataAnnotations;

namespace Silverback;

public class KafkaConfig
{
    [Required]
    public required string BootstrapServers { get; set; }
    [Required]
    public required string Topic { get; set; }
    [Required]
    public required string ConsumerGroupId { get; set; }
}