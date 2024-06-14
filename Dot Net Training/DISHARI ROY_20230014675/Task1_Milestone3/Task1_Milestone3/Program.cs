using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Task1_Milestone3.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Task1_Milestone3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Task1_Milestone3Context") ?? throw new InvalidOperationException("Connection string 'Task1_Milestone3Context' not found.")));

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
