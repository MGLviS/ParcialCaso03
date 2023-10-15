using DPA202302ParcialCaso0322101571.Data;
using DPA202302ParcialCaso0322101571.Interfaces;
using DPA202302ParcialCaso0322101571.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var _config = builder.Configuration; //obtener atributos de la cadena de conexion
var _cnx = _config.GetConnectionString("DevConnection"); // cadena de conexión
builder.Services.AddDbContext<Dpa202302parcialCaso0322101571Context>(options =>
{
    options.UseSqlServer(_cnx);
});

//Territory
builder.Services.AddTransient<IterritoryRepository, territoryRepository>();

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
