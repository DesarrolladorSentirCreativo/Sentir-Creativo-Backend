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
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.GetAll;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Motivaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Prefijos;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Rubros;
using Sentir_Creativo_Backend.Audiencias.Presenters.Antiguedades;
using Sentir_Creativo_Backend.Audiencias.Presenters.Audiencias;
using Sentir_Creativo_Backend.Audiencias.Presenters.Cercanias;
using Sentir_Creativo_Backend.Audiencias.Presenters.EstadoAudiencias;
using Sentir_Creativo_Backend.Audiencias.Presenters.Motivaciones;
using Sentir_Creativo_Backend.Audiencias.Presenters.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Presenters.Origenes;
using Sentir_Creativo_Backend.Audiencias.Presenters.Prefijos;
using Sentir_Creativo_Backend.Audiencias.Presenters.Rubros;

namespace Sentir_Creativo_Backend.Audiencias.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddAudienciasPresenters(this IServiceCollection services)
    {
        services.AddScoped<SelectOrigenPresenter>();
        services.AddScoped<ISelectOrigenPresenter>(provider => provider.GetService<SelectOrigenPresenter>());
        services.AddScoped<ISelectOrigenOutputPort>(provider => provider.GetService<SelectOrigenPresenter>());

        services.AddScoped<SelectAntiguedadPresenter>();
        services.AddScoped<ISelectAntiguedadPresenter>(provider => provider.GetService<SelectAntiguedadPresenter>());
        services.AddScoped<ISelectAntiguedadOutputPort>(provider => provider.GetService<SelectAntiguedadPresenter>());

        services.AddScoped<SelectCercaniaPresenter>();
        services.AddScoped<ISelectCercaniaPresenter>(provider => provider.GetService<SelectCercaniaPresenter>());
        services.AddScoped<ISelectCercaniaOutputPort>(provider => provider.GetService<SelectCercaniaPresenter>());

        services.AddScoped<SelectMotivacionPresenter>();
        services.AddScoped<ISelectMotivacionPresenter>(provider => provider.GetService<SelectMotivacionPresenter>());
        services.AddScoped<ISelectMotivacionOutputPort>(provider => provider.GetService<SelectMotivacionPresenter>());

        services.AddScoped<SelectPrefijoPresenter>();
        services.AddScoped<ISelectPrefijoPresenter>(provider => provider.GetService<SelectPrefijoPresenter>());
        services.AddScoped<ISelectPrefijoOutputPort>(provider => provider.GetService<SelectPrefijoPresenter>());
        
        services.AddScoped<SelectOrganizacionPresenter>();
        services.AddScoped<ISelectOrganizacionPresenter>(provider => provider.GetService<SelectOrganizacionPresenter>());
        services.AddScoped<ISelectOrganizacionOutputPort>(provider => provider.GetService<SelectOrganizacionPresenter>());

        services.AddScoped<GetByIdAudienciaPresenter>();
        services.AddScoped<IGetByIdAudienciaPresenter>(provider => provider.GetService<GetByIdAudienciaPresenter>());
        services.AddScoped<IGetByIdAudienciaOutputPort>(provider => provider.GetService<GetByIdAudienciaPresenter>());
        
        services.AddScoped<PaginationAudienciaPresenter>();
        services.AddScoped<IPaginationAudienciaPresenter>(provider => provider.GetService<PaginationAudienciaPresenter>());
        services.AddScoped<IPaginationAudienciaOuputPort>(provider => provider.GetService<PaginationAudienciaPresenter>());
        
        services.AddScoped<SearchAudienciasDifusionPresenter>();
        services.AddScoped<ISearchAudienciasDifusionPresenter>(provider => provider.GetService<SearchAudienciasDifusionPresenter>());
        services.AddScoped<ISearchAudienciasDifusionOutputPort>(provider => provider.GetService<SearchAudienciasDifusionPresenter>());
        
        services.AddScoped<CreateAudienciaPresenter>();
        services.AddScoped<ICreateAudienciaPresenter>(provider => provider.GetService<CreateAudienciaPresenter>());
        services.AddScoped<ICreateAudienciaOutputPort>(provider => provider.GetService<CreateAudienciaPresenter>());
        
        services.AddScoped<UpdateAudienciaPresenter>();
        services.AddScoped<IUpdateAudienciaPresenter>(provider => provider.GetService<UpdateAudienciaPresenter>());
        services.AddScoped<IUpdateAudienciaOutputPort>(provider => provider.GetService<UpdateAudienciaPresenter>());
        
        services.AddScoped<GetAllAudienciaPresenter>();
        services.AddScoped<IGetAllAudienciaPresenter>(provider => provider.GetService<GetAllAudienciaPresenter>());
        services.AddScoped<IGetAllAudienciaOutputPort>(provider => provider.GetService<GetAllAudienciaPresenter>());
        
        services.AddScoped<DeleteAudienciaPresenter>();
        services.AddScoped<IDeleteAudienciaPresenter>(provider => provider.GetService<DeleteAudienciaPresenter>());
        services.AddScoped<IDeleteAudienciaOutputPort>(provider => provider.GetService<DeleteAudienciaPresenter>());
        
        services.AddScoped<SelectEstadoAudienciaPresenter>();
        services.AddScoped<ISelectEstadoAudienciaPresenter>(provider => provider.GetService<SelectEstadoAudienciaPresenter>());
        services.AddScoped<ISelectEstadoAudienciaOutputPort>(provider => provider.GetService<SelectEstadoAudienciaPresenter>());
        
        services.AddScoped<GetAllOrganizacionPresenter>();
        services.AddScoped<IGetAllOrganizacionPresenter>(provider => provider.GetService<GetAllOrganizacionPresenter>());
        services.AddScoped<IGetAllOrganizacionOutputPort>(provider => provider.GetService<GetAllOrganizacionPresenter>());
        
        services.AddScoped<GetAllOrganizacionPresenter>();
        services.AddScoped<IGetAllOrganizacionPresenter>(provider => provider.GetService<GetAllOrganizacionPresenter>());
        services.AddScoped<IGetAllOrganizacionOutputPort>(provider => provider.GetService<GetAllOrganizacionPresenter>());
        
        services.AddScoped<SelectRubroPresenter>();
        services.AddScoped<ISelectRubroPresenter>(provider => provider.GetService<SelectRubroPresenter>());
        services.AddScoped<ISelectRubroOutputPort>(provider => provider.GetService<SelectRubroPresenter>());
        
        services.AddScoped<CreateOrganizacionPresenter>();
        services.AddScoped<ICreateOrganizacionPresenter>(provider => provider.GetService<CreateOrganizacionPresenter>());
        services.AddScoped<ICreateOrganizacionOutputPort>(provider => provider.GetService<CreateOrganizacionPresenter>());
        
        return services;
    }
}