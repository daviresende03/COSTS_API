using COSTS_API.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string connectString = builder.Configuration.GetConnectionString("MySQL_DbContext");

//Conectando ao banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(connectString, ServerVersion.AutoDetect(connectString), builder =>
            builder.MigrationsAssembly("COSTS_API")));

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
