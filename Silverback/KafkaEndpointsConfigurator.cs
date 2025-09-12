using Confluent.Kafka;
using Silverback.Messaging.Configuration;
using Microsoft.Extensions.Options;

namespace Silverback;

public class KafkaEndpointsConfigurator(IOptions<KafkaConfig> kafkaConfigOptions) : IEndpointsConfigurator
{
    readonly KafkaConfig _kafkaConfig = kafkaConfigOptions.Value;

    public void Configure(IEndpointsConfigurationBuilder builder)
    {
        builder
            .AddKafkaEndpoints(
                endpoints => endpoints
                    .Configure(
                        config =>
                        {
                            config.BootstrapServers = _kafkaConfig.BootstrapServers;
                        })
                    .AddInbound(
                        endpoint => endpoint
                            .SkipNullMessages()
                            .ConsumeFrom(_kafkaConfig.Topic)
                            .DeserializeJson(json => json.UseFixedType<Event>())
                            .Configure(
                                config =>
                                {
                                    // The consumer needs at least the bootstrap
                                    // server address and a group id to be able
                                    // to connect
                                    config.GroupId = _kafkaConfig.GroupId;

                                    // AutoOffsetReset.Earliest means that the
                                    // consumer must start consuming from the
                                    // beginning of the topic, if no offset was
                                    // stored for this consumer group
                                    config.AutoOffsetReset = AutoOffsetReset.Earliest;
                                })
                        ));
    }
}