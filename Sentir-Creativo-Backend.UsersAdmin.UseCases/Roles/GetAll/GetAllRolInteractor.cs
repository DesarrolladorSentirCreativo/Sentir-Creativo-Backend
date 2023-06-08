using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.GetAll;

public class GetAllRolInteractor : IGetAllRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly IGetAllRolOutputPort _outputPort;
    
    public GetAllRolInteractor(IReadRepository<Rol, int> readRepository,
        IGetAllRolOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new RolActivosSpecification();

        var roles = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllRolViewModel> data = roles
            .Select(p => 
                new GetAllRolViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}