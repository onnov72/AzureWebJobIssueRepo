using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var builder = new HostBuilder();
builder.ConfigureWebJobs(b =>
{
    b.AddAzureStorageCoreServices();
});

builder.ConfigureLogging((context, configure) =>
{
    configure.AddConsole();
});

using (var host = builder.Build())
{
    await host.RunAsync();
}
