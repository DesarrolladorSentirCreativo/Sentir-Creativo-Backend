using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.ColeccionesUserAdmin;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Delete;

public class DeleteColeccionUserAdminInteractor : IDeleteColeccionUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<ColeccionUserAdmin,int> _readRepository;
    private readonly IDeleteColeccionUserAdminOutputPort _outputPort;

    public DeleteColeccionUserAdminInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<ColeccionUserAdmin, int> readRepository,
        IDeleteColeccionUserAdminOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int coleccionUserAdminId)
    {
        var spec = new ColeccionUserAdminActivoByIdSpecification(coleccionUserAdminId);

        var coleccionUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (coleccionUserAdmin == null) throw new Exception("La coleccion no se encuentra registrada");
        
        coleccionUserAdmin.Activo = false;
        
        _unitOfWork.WriteRepository<ColeccionUserAdmin,int>().UpdateEntity(coleccionUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de colecciones");
        }

        await _outputPort.Handle(coleccionUserAdmin.Id);
    }
}