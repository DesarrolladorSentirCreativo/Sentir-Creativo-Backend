using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Delete;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Specifications.Organizaciones;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Delete;

public class DeleteOrganizacionInteractor : IDeleteOrganizacionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Organizacion,int> _readRepository;
    private readonly IDeleteOrganizacionOutputPort _outputPort;

    public DeleteOrganizacionInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<Organizacion, int> readRepository,
        IDeleteOrganizacionOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int organizacionId)
    {
        var spec = new OrganizacionByIdSpecification(organizacionId);

        var organizacion = await _readRepository.GetByIdWithSpec(spec);
        
        if (organizacion == null) throw new NotFoundException("La organizacion no se encuentra registrada");
        
        organizacion.Activo = false;
        
        _unitOfWork.WriteRepository<Organizacion,int>().UpdateEntity(organizacion);

        await _unitOfWork.Complete();

        await _outputPort.Handle(organizacionId);
    }
}