using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.AFP;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.GetAll;

public class GetAllAfpInteractor : IGetAllAfpInputPort
{
    private readonly IReadRepository<Afp,int> _readRepository;
    private readonly IGetAllAfpOutputPort _outputPort;
    
    public GetAllAfpInteractor(IReadRepository<Afp, int> readRepository,
        IGetAllAfpOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new AfpActivosSpecification();

        var afp = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllAfpViewModel> data = afp
            .Select(p => 
                new GetAllAfpViewModel()
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