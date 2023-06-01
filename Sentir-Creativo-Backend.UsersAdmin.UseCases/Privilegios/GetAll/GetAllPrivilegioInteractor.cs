using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.GetAll;

public class GetAllPrivilegioInteractor : IGetAllPrivilegioInputPort
{
    private readonly IReadRepository<Privilegio,string> _readRepository;
    private readonly IGetAllPrivilegioOutputPort _outputPort;
    
    public GetAllPrivilegioInteractor(
        IReadRepository<Privilegio, string> readRepository,
        IGetAllPrivilegioOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    
    public async ValueTask Handle()
    {
        var spec = new PrivilegioActivosSpecification();

        var privilegios = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<GetAllPrivilegioViewModel> data = privilegios
            .Select(p => 
                new GetAllPrivilegioViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,
                    CategoriaId = p.CategoriaId,
                    Descripcion = p.Descripcion,
                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}
