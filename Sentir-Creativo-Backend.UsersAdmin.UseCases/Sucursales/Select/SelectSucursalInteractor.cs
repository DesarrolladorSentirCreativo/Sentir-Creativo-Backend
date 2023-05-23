using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Select;

public class SelectSucursalInteractor : ISelectSucursalInputPort
{
    private readonly IReadRepository<Sucursal,int> _readRepository;
    private readonly ISelectSucursalOutputPort _outputPort;
    
    public SelectSucursalInteractor(
        IReadRepository<Sucursal,int> readRepository, 
        ISelectSucursalOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle()
    {
        var spec = new SucursalActivosSpecification();

        var sucursales = await _readRepository.GetAllWithSpec(spec);
        
        IReadOnlyList<SelectSucursalViewModel> data = sucursales
            .Select(p => 
                new SelectSucursalViewModel()
                {
                    Id = p.Id,
                    Nombre = p.Nombre,

                })
            .ToList()
            .AsReadOnly();

        await _outputPort.Handle(data);
    }
}