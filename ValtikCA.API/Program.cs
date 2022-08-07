using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using ValtikCA.Application;
using ValtikCA.Application.Interfaces;
using ValtikCA.Application.Services;
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

builder.Services.AddTransient<ICategoriaService, CategoriaService>();
builder.Services.AddTransient<IClienteService, ClienteService>();
builder.Services.AddTransient<IOrdenService, OrdenService>();
builder.Services.AddTransient<IProductoCategoriaService, ProductoCategoriaService>();
builder.Services.AddTransient<IProductoService, ProductoService>();
builder.Services.AddTransient<IProductoXordenService, ProductoXordenService>();
builder.Services.AddTransient<IAutorizacionesService, AutorizacionesService>();


builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IProductoCategoriaRepository, ProductoCategoriaRepository>();
builder.Services.AddTransient<IProductosXordenRepository, ProductosXordenRepository>();
builder.Services.AddTransient<IOrdenRepository, OrdenRepository>();
builder.Services.AddTransient<IAutorizacionesRepository, AutorizacionesRepository>();


/*
builder.Services.AddDbContext<CinemaContext>(optionsBuilder => optionsBuilder.UseSqlServer("name=ConnectionStrings:Cinema"));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddApplicationServices();
//Registrar las dependencias
builder.Services.AddTransient<ISalaRepository, SalaRepository>();
*/

//Autenticacion con JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    //Se definen los parametros de validación del token
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = "https://localhost:7194",
        ValidAudience = "https://localhost:7194",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Valtik2022&Ciaasdasfasdfadsffdsgas"))
    };
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "ValtikCA API",
        Description = "Estas son los endpoints disponibles para la API ValtikCA"
    });

    //Obtener de forma dinamica el nombre del archivo
    var nombreArchivo = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";

    //Creamos una variable con la ruta completa del archivo
    var xmlPath = Path.Combine(AppContext.BaseDirectory, nombreArchivo);

    options.IncludeXmlComments(xmlPath);
});

try
{
    var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        //Especificar la url en donde se encuentra el swagger de la API
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "ValtikCA API v1");

        //Especificar que swagger sea la pagina por defecto
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

//Se registra la autenticación
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

}
catch (Exception ex)
{
    Console.WriteLine("el error es:");
    Console.WriteLine(ex.ToString());
}

