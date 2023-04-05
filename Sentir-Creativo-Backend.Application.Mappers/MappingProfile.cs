using AutoMapper;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.Commands.Creator;
using Sentir_Creativo_Backend.Audiencias.Application.Audiencias.Features.ViewModel;
using Sentir_Creativo_Backend.Audiencias.Application.Cercanias.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.EstadosAudiencias.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.Origenes.Features.ViewModels;
using Sentir_Creativo_Backend.Audiencias.Application.Prefijos.Features.ViewModel;
using Sentir_Creativo_Backend.Audiencias.Domain.Entities;

namespace Sentir_Creativo_Backend.Application.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Audiencia, AudienciaViewModel>()
            .ForMember(p => p.Motivacion, x => x.MapFrom(a => a.Motivacion!.Nombre))
            .ForMember(p => p.EstadoAudiencia, x => x.MapFrom(a => a.EstadoAudiencia!.Nombre))
            .ForMember(p => p.Origen, x => x.MapFrom(a => a.Origen!.Nombre))
            .ForMember(p => p.Organizacion, x => x.MapFrom(a => a.Organizacion!.Nombre))
            .ForMember(p => p.Prefijo, x => x.MapFrom(a => a.Prefijo!.Nombre))
            .ForMember(p => p.Antiguedad, x => x.MapFrom(a => a.Antiguedad!.Nombre));;
        CreateMap<Prefijo, SelectPrefijoViewModel>();
        CreateMap<Origen, SelectOrigenViewModel>();
        CreateMap<EstadoAudiencia, SelectEstadoAudienciaViewModel>();
        CreateMap<Cercania, SelectCercaniaViewModel>();
        CreateMap<CreateAudienciaCommand, Audiencia>();
    }
}