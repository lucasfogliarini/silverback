using Silverback;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddKafka();
    })
    .Build();

await host.RunAsync();
