namespace Silverback;

public class KafkaConfig
{
    public string BootstrapServers { get; set; } = "";
    public string Topic { get; set; } = "TST_SicredMatone.USUARIOS";
    public string GroupId { get; set; } = "group1";
}