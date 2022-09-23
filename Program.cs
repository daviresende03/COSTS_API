using COSTS_API.Infra.Data;
using COSTS_API.Interfaces;
using COSTS_API.Services;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
string connectString = builder.Configuration.GetConnectionString("MySQL_DbContext");

//Conectando ao banco de dados
builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseMySql(connectString, ServerVersion.AutoDetect(connectString), builder =>
            builder.MigrationsAssembly("COSTS_API")));

// Add services to the container.

//builder.Services.AddControllers();
builder.Services.AddControllers(options =>
{
    options.OutputFormatters.RemoveType<SystemTextJsonOutputFormatter>();
    options.OutputFormatters.Add(new SystemTextJsonOutputFormatter(new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        ReferenceHandler = ReferenceHandler.Preserve,
    }));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProject, ProjectService>();

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
