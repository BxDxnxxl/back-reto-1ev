using back.Controllers;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Configuración de CORS para permitir solicitudes desde ciertos orígenes
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
    {
        policy.WithOrigins(
            "http://54.242.122.114",   // IP pública de tu servidor (ajustar según sea necesario)
            "http://localhost:80",      // Puerto 80 del frontend en local
            "http://127.0.0.1:5500"    // Puedes quitar este si no lo necesitas
        )
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// Configuración de servicios para usar controladores y generar la documentación de Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Mi API", Version = "v1" });
});

// Inicialización de datos (si tienes alguna lógica para cargar datos al inicio)
InicializadorDatos.InicializarDatos();

var app = builder.Build();

// Si estamos en un entorno de desarrollo, habilitar Swagger para pruebas
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API v1");
    });
}

app.UseHttpsRedirection();

// Habilitar CORS con la política definida
app.UseCors("AllowSpecificOrigin");

app.UseAuthorization();

// Configurar las rutas para los controladores
app.MapControllers();

// Configurar la API para que escuche en todas las interfaces (para Docker y entornos externos)
app.Run("http://0.0.0.0:7103"); // Escucha en todas las interfaces de red en el puerto 7103
