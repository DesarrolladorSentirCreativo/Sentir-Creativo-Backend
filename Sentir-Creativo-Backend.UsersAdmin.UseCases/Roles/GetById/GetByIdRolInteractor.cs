using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.GetById;

public class GetByIdRolInteractor : IGetByIdRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly IGetByIdRolOutputPort _outputPort;
    
    public GetByIdRolInteractor(
        IReadRepository<Rol, int> readRepository,
        IGetByIdRolOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int rolId)
    {
        var spec = new RolActivoByIdSpecification(rolId);

        var rol = await _readRepository.GetByIdWithSpec(spec);

        if (rol == null) throw new Exception("El rol no se encuentra registrada");

        var data = new GetByIdRolViewModel()
        {
            Id = rol.Id,
            Nombre = rol.Nombre,
            Descripcion = rol.Descripcion,
        };
        
        await _outputPort.Handle(data);
    }
}