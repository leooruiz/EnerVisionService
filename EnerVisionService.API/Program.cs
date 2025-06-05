using Microsoft.OpenApi.Models;
using EnerVisionService.Application.Services;
using EnerVisionService.Domain.Interfaces;
using EnerVisionService.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços da API
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // necessário pro Swagger
builder.Services.AddSwaggerGen();

// Injeta dependências
builder.Services.AddSingleton<IPowerOutageRepository, PowerOutageRepository>();
builder.Services.AddScoped<PowerOutageService>();

var app = builder.Build();

// Ativa o Swagger sempre
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers(); // necessário para mapear os endpoints REST da pasta Controllers

app.Run();