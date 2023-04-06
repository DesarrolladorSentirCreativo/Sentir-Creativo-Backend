using Sentir_Creativo_Backend.Audiencias.IoC;
using Sentir_Creativo_Backend.SharedKernel.IoC;
using Sentir_Creativo_Backend.WebApi.Audiencias.Origenes;

namespace Sentir_Creativo_Backend.WebApi;

public static class WebApplicationHelper
{
    public static WebApplication CreateWebApplication(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddSharedKernelRepositoriesServices(builder.Configuration);
        builder.Services.AddAudienciasServices();

        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(config =>
            {
                config.AllowAnyMethod();
                config.AllowAnyOrigin();
                config.AllowAnyHeader();
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

        app.UseOrigenEndpoints();

        return app;
    }
}