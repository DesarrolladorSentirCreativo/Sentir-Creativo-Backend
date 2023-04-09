using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencias.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencias.Controllers.Prefijos;

namespace Sentir_Creativo_Backend.Audiencias.Controllers;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasControllers(this IServiceCollection services)
    {
        services.AddScoped<ISelectOrigenController, SelectOrigenController>();
        services.AddScoped<ISelectAntiguedadController, SelectAntiguedadController>();
        services.AddScoped<ISelectCercaniaController, SelectCercaniaController>();
        services.AddScoped<ISelectMotivacionController, SelectMotivacionController>();
        services.AddScoped<ISelectPrefijoController, SelectPrefijoController>();
        services.AddScoped<ISelectOrganizacionController, SelectOrganizacionController>();
        services.AddScoped<IGetByIdAudienciaController, GetByIdAudienciaController>();
        
        return services;
    }
}