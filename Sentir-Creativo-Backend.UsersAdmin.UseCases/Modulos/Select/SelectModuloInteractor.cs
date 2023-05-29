using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Select;

public class SelectModuloInteractor : ISelectModuloInputPort
{
    private readonly IReadRepository<Modulo,int> _readRepository;
    private readonly ISelectModuloOutputPort _outputPort;

    public SelectModuloInteractor(
        IReadRepository<Modulo, int> readRepository, 
        ISelectModuloOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ModuloActivosSpecification();

        var modulos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectModuloViewModel> data = modulos
            .Select(p => 
                new SelectModuloViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}