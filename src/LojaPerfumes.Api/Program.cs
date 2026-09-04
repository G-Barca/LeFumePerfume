var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "LojaPerfumes.Api");

app.Run();
