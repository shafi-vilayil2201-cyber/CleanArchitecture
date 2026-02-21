using CleanArchitecture.Infrastructure;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();   // ⭐ REQUIRED

builder.Services.AddInfrastructure();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();   // ⭐ REQUIRED

app.Run();