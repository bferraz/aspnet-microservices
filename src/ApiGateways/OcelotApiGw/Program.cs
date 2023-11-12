using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", true, true)
                            .Build();

builder.Logging.AddConsole();

builder.Services.AddOcelot(configuration);

var app = builder.Build();

app.UseHttpLogging();

await app.UseOcelot();

app.Run();
