using Microsoft.EntityFrameworkCore;

using WebAppAcademica.Models;

var builder = WebApplication.CreateBuilder(args);

// Servicios
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configura MyDbContext (ajusta la cadena en appsettings.json)
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Swagger solo en desarrollo
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Forzar HTTPS primero (recomendado)
app.UseHttpsRedirection();

// Servir index.html por defecto y archivos estáticos desde wwwroot
var defaultFilesOptions = new DefaultFilesOptions();
defaultFilesOptions.DefaultFileNames.Clear();
defaultFilesOptions.DefaultFileNames.Add("index.html");
app.UseDefaultFiles(defaultFilesOptions);
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Endpoints de API
app.MapControllers();

// Fallback para SPA: cualquier ruta no manejada devuelve index.html
app.MapFallbackToFile("index.html");

app.Run();
