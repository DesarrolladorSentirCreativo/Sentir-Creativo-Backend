using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.DireccionById;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Organizaciones;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.DireccionById;

public class DireccionByIdOrganizacionInteractor : IDireccionByIdOrganizacionInputPort
{
    private readonly IReadRepository<OrganizacionDireccion,int> _readRepository;
    private readonly IDireccionByIdOrganizacionOutputPort _outputPort;
    
    public DireccionByIdOrganizacionInteractor(
        IReadRepository<OrganizacionDireccion,int> readRepository, 
        IDireccionByIdOrganizacionOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int organizacionId)
    {
        var spec = new DireccionOrganizacionByIdSpecification(organizacionId);

        var organizacionDireccion = await _readRepository.GetByIdWithSpec(spec);

        if (organizacionDireccion == null)
        {
            throw new NotFoundException($"La direccion de la organizacion {organizacionId} no existe");
        }
        
        await _outputPort.Handle(new DireccionByIdOrganizacionViewModel()
        {
            DireccionId = organizacionDireccion.DireccionId,
            PaisId = organizacionDireccion.Direccion!.PaisId,
            RegionId = organizacionDireccion.Direccion!.RegionId,
            CiudadId = organizacionDireccion.Direccion!.CiudadId,
            Calle = organizacionDireccion.Direccion!.Calle
        });
    }
}