using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Roles.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Roles;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Roles;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Roles.Select;

public class SelectRolInteractor : ISelectRolInputPort
{
    private readonly IReadRepository<Rol,int> _readRepository;
    private readonly ISelectRolOutputPort _outputPort;
    
    public SelectRolInteractor(IReadRepository<Rol, int> readRepository,
        ISelectRolOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new RolActivosSpecification();

        var roles = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectRolViewModel> data = roles
            .Select(p => 
                new SelectRolViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}