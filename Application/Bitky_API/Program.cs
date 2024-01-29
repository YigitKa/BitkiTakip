using Bitky_API.Models.DapperContext;
using Bitky_API.Repositories.PlantRepository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Context register
builder.Services.AddTransient<Context>();

// Bitkiler servisi register
builder.Services.AddTransient<IPlantRepository, PlantRepository>();

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

