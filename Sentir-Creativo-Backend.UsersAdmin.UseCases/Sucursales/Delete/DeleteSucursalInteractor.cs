using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Sucursales.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Sucursales;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Sucursales.Delete;

public class DeleteSucursalInteractor : IDeleteSucursalInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDeleteSucursalOutputPort _outputPort;
    private readonly IReadRepository<Sucursal,int> _readRepository;

    public DeleteSucursalInteractor(
        IUnitOfWork unitOfWork,
        IDeleteSucursalOutputPort outputPort,
        IReadRepository<Sucursal,int> readRepository)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _readRepository = readRepository;
    }

    
    public async ValueTask Handle(int sucursalId)
    {
        var spec = new SucursalActivoByIdSpecification(sucursalId);

        var sucursal = await _readRepository.GetByIdWithSpec(spec);
        
        
        if (sucursal == null) throw new Exception("La sucursal no se encuentra registrada");

        sucursal.Activo = false;
        
        _unitOfWork.WriteRepository<Sucursal>().UpdateEntity(sucursal);

        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de sucursales");
        }

        await _outputPort.Handle(sucursalId);
    }
}