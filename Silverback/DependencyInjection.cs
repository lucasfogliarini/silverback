namespace Silverback;

public static class DependencyInjection
{
    public static IServiceCollection AddKafka(this IServiceCollection services)
    {
        services.AddOptions<KafkaConfig>()
            .BindConfiguration(nameof(KafkaConfig))
            .ValidateOnStart();

        services
            .AddSilverback()
            .WithConnectionToMessageBroker(options => options.AddKafka())
            .AddEndpointsConfigurator<KafkaEndpointsConfigurator>()
            .AddScopedSubscriber<EventCreatedSubscriber>();
        return services;
    }
}