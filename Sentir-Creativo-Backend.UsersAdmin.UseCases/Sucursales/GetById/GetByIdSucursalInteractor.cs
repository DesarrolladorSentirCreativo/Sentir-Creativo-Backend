using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.GetById;

public class GetByIdSucursalInteractor : IGetByIdSucursalInputPort
{
    private readonly IReadRepository<Sucursal,int> _readRepository;
    private readonly IGetByIdSucursalOutputPort _outputPort;

    public GetByIdSucursalInteractor(IReadRepository<Sucursal, int> readRepository,
        IGetByIdSucursalOutputPort outputPort)
    {
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int sucursalId)
    {

        var spec = new SucursalActivoByIdSpecification(sucursalId);

        var sucursal = await _readRepository.GetByIdWithSpec(spec);

        if (sucursal == null) throw new Exception("La sucursal no se encuentra registrada");

        var modelView = new GetByIdSucursalViewModel()
        {
            Id = sucursal.Id,
            Nombre = sucursal.Nombre,
            Descripcion = sucursal.Descripcion,
            Direccion = sucursal.Direccion,
            ComunaId = sucursal.ComunaId,
            RegionId = sucursal.RegionId,
            PaisId = sucursal.PaisId
        };

        await _outputPort.Handle(modelView);
    }
}