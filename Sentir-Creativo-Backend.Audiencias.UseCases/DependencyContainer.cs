using Microsoft.Extensions.DependencyInjection;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Delete;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.SearchAudienciaDifusiones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Audiencias.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.EstadoAudiencias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Create;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Delete;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.GetAll;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.GetById;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Pagination;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.SearchAudienciasDifusion;
using Sentir_Creativo_Backend.Audiencias.UseCases.Audiencias.Update;
using Sentir_Creativo_Backend.Audiencias.UseCases.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.EstadosAudiencias.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Motivaciones.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Create;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Delete;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.DireccionById;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Update;
using Sentir_Creativo_Backend.Audiencias.UseCases.Origenes.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencias.UseCases.Rubros.Select;

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
        services.AddScoped<ISearchAudienciasDifusionInputPort, SearchAudienciasDifusionInteractor>();
        services.AddScoped<ICreateAudienciaInputPort, CreateAudienciaInteractor>();
        services.AddScoped<IUpdateAudienciaInputPort, UpdateAudienciaInteractor>();
        services.AddScoped<IGetAllAudienciaInputPort, GetAllAudienciaInteractor>();
        services.AddScoped<IDeleteAudienciaInputPort, DeleteAudienciaInteractor>();
        services.AddScoped<ISelectEstadoAudienciaInputPort, SelectEstadoAudienciaInteractor>();
        services.AddScoped<IGetAllOrganizacionInputPort, GetAllOrganizacionInteractor>();
        services.AddScoped<ISelectRubroInputPort, SelectRubroInteractor>();
        services.AddScoped<ICreateOrganizacionInputPort, CreateOrganizacionInteractor>();
        services.AddScoped<IDeleteOrganizacionInputPort, DeleteOrganizacionInteractor>();
        services.AddScoped<IDireccionByIdOrganizacionInputPort, DireccionByIdOrganizacionInteractor>();
        services.AddScoped<IUpdateOrganizacionInputPort, UpdateOrganizacionInteractor>();
        
        return services;
    }
}