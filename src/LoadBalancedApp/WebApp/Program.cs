var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => $"Hello from instance: {Environment.MachineName}");

app.Run();
