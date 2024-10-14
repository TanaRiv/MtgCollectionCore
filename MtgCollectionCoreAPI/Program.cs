using Microsoft.EntityFrameworkCore;
using MtgCollectionCoreAPI.Db;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Registrar el DbContext y usar SQL Server con la cadena de conexión
builder.Services.AddDbContext<MtgCollectionContext>(options =>
    options.UseSqlServer(connectionString));

// Añadir servicios de controladores y otras configuraciones de la API
builder.Services.AddControllers();
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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
