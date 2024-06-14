using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApplication16_Exercise.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<WebApplication16_ExerciseContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplication16_ExerciseContext") ?? throw new InvalidOperationException("Connection string 'WebApplication16_ExerciseContext' not found.")));

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
