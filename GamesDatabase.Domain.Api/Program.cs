using GamesDatabase.Domain.Handlers;
using GamesDatabase.Domain.Infra.Contexts;
using GamesDatabase.Domain.Infra.Repositories;
using GamesDatabase.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Dependencias
builder.Services.AddDbContext<GamesContext>(opt => opt.UseInMemoryDatabase("Database"));

builder.Services.AddTransient<IGameRepository, GamesRepository>();
builder.Services.AddTransient<GameHandler, GameHandler>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapControllers();

app.Run();
