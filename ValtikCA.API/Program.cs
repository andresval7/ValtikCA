using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using ValtikCA.Application;
using ValtikCA.Domain.Interfaces;
using ValtikCA.Infrastructure.Filters;
using ValtikCA.Infrastructure.Persistence;
using ValtikCA.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.Filters.Add<GlobalExceptionFilter>();
}).AddFluentValidation();

builder.Services.AddDbContext<DBTiendaValtikContext>
(optionsBuilder => optionsBuilder.UseSqlServer("name=ConnectionStrings:DBTiendaValtik"));

builder.Services.AddApplicationServices();

builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IProductoCategoriumRepository, ProductoCategoriumRepository>();
builder.Services.AddTransient<IProductosXordenRepository, ProductosXordenRepository>();
builder.Services.AddTransient<ITblOrdeneRepository, TblOrdeneRepository>();

/*
builder.Services.AddDbContext<CinemaContext>(optionsBuilder => optionsBuilder.UseSqlServer("name=ConnectionStrings:Cinema"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApplicationServices();
//Registrar las dependencias
builder.Services.AddTransient<ISalaRepository, SalaRepository>();
*/

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
