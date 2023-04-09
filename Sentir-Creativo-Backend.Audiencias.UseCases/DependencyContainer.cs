using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencias.UseCases.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Origenes.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Prefijos.Select;

namespace Sentir_Creativo_Backend.Audiencias.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<ISelectOrigenInputPort, SelectOrigenInteractor>();
        services.AddScoped<ISelectAntiguedadInputPort, SelectAntiguedadInteractor>();
        services.AddScoped<ISelectCercaniaInputPort, SelectCercaniaInteractor>();
        services.AddScoped<ISelectMotivacionInputPort, SelectMotivacionInteractor>();
        services.AddScoped<ISelectPrefijoInputPort, SelectPrefijoInteractor>();
        services.AddScoped<ISelectOrganizacionInputPort, SelectOrganizacionInteractor>();
        services.AddScoped<IGetByIdAudienciaInputPort, GetByIdAudienciaInteractor>();
        services.AddScoped<IPaginationAudienciaInputPort, PaginationAudienciaInteractor>();
        
        return services;
    }
}