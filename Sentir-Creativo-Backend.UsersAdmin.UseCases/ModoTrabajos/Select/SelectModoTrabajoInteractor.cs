using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ModoTrabajos.Select;

public class SelectModoTrabajoInteractor : ISelectModoTrabajoInputPort
{
    private readonly IReadRepository<ModoTrabajo,int> _readRepository;
    private readonly ISelectModoTrabajoOutputPort _outputPort;
    
    public SelectModoTrabajoInteractor(
        IReadRepository<ModoTrabajo, int> readRepository,
        ISelectModoTrabajoOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new ModoTrabajoActivosSpecification();

        var modoTrabajos = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectModoTrabajoViewModel> data = modoTrabajos
            .Select(p => 
                new SelectModoTrabajoViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}