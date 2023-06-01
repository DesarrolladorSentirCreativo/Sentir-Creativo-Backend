using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.Modulos;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Modulos.Delete;

public class DeleteModuloInteractor : IDeleteModuloInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Modulo,int> _readRepository;
    private readonly IDeleteModuloOutputPort _outputPort;

    public DeleteModuloInteractor(
        IUnitOfWork unitOfWork, IReadRepository<Modulo, int> readRepository,
        IDeleteModuloOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    public async ValueTask Handle(int moduloId)
    {

        var spec = new ModuloActivoByIdSpecification(moduloId);

        var modulo = await _readRepository.GetByIdWithSpec(spec);

        if (modulo == null) throw new Exception("El modulo no se encuentra registrada");

        modulo.Activo = false;
        
        _unitOfWork.WriteRepository<Modulo,int>().UpdateEntity(modulo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de modulos");
        }

        await _outputPort.Handle(modulo.Id);
    }
}