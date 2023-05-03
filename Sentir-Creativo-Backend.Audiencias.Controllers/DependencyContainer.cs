using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Controllers.Rubros;
using Sentir_Creativo_Backend.Audiencias.Controllers.Antiguedades;
using Sentir_Creativo_Backend.Audiencias.Controllers.Audiencias;
using Sentir_Creativo_Backend.Audiencias.Controllers.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Controllers.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencias.Controllers.Motivaciones;
using Sentir_Creativo_Backend.Audiencias.Controllers.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Controllers.Origenes;
using Sentir_Creativo_Backend.Audiencias.Controllers.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Controllers.Rubros;

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
        services.AddScoped<IPaginationAudienciaController, PaginationAudienciaController>();
        services.AddScoped<ISearchAudienciasDifusionController, SearchAudienciasDifusionController>();
        services.AddScoped<ICreateAudienciaController, CreateAudienciaController>();
        services.AddScoped<IUpdateAudienciaController, UpdateAudienciaController>();
        services.AddScoped<IGetAllAudienciaController, GetAllAudienciaController>();
        services.AddScoped<IDeleteAudienciaController, DeleteAudienciaController>();
        services.AddScoped<ISelectEstadoAudienciaController, SelectEstadoAudienciaController>();
        services.AddScoped<IGetAllOrganizacionController, GetAllOrganizacionController>();
        services.AddScoped<ISelectRubroController, SelectRubroController>();
        services.AddScoped<ICreateOrganizacionController, CreateOrganizacionController>();
        services.AddScoped<IDeleteOrganizacionController, DeleteOrganizacionController>();
        services.AddScoped<IDireccionByIdOrganizacionController, DireccionByIdOrganizacionController>();
        services.AddScoped<IUpdateOrganizacionController, UpdateOrganizacionController>();
        
        return services;
    }
}