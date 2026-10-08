using LojaPerfumes.Application.Interfaces;
using LojaPerfumes.Infrastructure.Persistence;
using LojaPerfumes.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MySql")
                       ?? throw new InvalidOperationException("Connection string 'MySql' não foi encontrada.");

// AddDbContext já registra o contexto com ciclo de vida Scoped
builder.Services.AddDbContext<LojaPerfumesContext>(options => options.UseMySQL(connectionString));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

var app = builder.Build();

app.MapGet("/", () => "LojaPerfumes.Api");

app.Run();