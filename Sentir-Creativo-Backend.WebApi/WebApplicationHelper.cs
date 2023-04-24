using Sentir_Creativo_Backend.Archivos.IoC;
using Sentir_Creativo_Backend.Areas.IoC;
using Sentir_Creativo_Backend.Audiencias.IoC;
using Sentir_Creativo_Backend.Colecciones.IoC;
using Sentir_Creativo_Backend.CuponesDescuentos.IoC;
using Sentir_Creativo_Backend.Difusiones.IoC;
using Sentir_Creativo_Backend.Proyectos.IoC;
using Sentir_Creativo_Backend.PublicoObjetivos.IoC;
using Sentir_Creativo_Backend.Servicios.IoC;
using Sentir_Creativo_Backend.SharedKernel.IoC;
using Sentir_Creativo_Backend.UsersAdmins.IoC;
using Sentir_Creativo_Backend.WebExceptionsPresenters;

namespace Sentir_Creativo_Backend.WebApi;

public static class WebApplicationHelper
{
    public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
    {
        builder.Services.AddControllers(Filters.Register);
        builder.Services.AddEndpointsApiExplorer();
        
        builder.Services.AddSwaggerGen();

        builder.Services.AddHttpClient();
        builder.Services.AddLogging();
        builder.Services.AddSharedKernelRepositoriesServices(builder.Configuration);
        builder.Services.AddAudienciasServices();
        builder.Services.AddProyectosServices();
        builder.Services.AddPublicoObjetivosServices();
        builder.Services.AddServiciosServices();
        builder.Services.AddColeccionesServices();
        builder.Services.AddAreasServices();
        builder.Services.AddUserAdminServices(builder.Configuration);
        builder.Services.AddDifusionesServices();
        builder.Services.AddCuponesDescuentosServices();
        builder.Services.AddArchivosServices();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            });
        });
        
        
        return builder.Build();
    }

    public static WebApplication ConfigureWebApplication(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseHttpsRedirection();
        
        app.UseCors("CorsPolicy");
        
        app.MapControllers();
        
        
        return app;
    }
}