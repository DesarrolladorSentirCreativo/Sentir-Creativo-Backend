using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaUserAdmins.Delete;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaUserAdmins;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Delete;

public class DeleteCategoriaUserAdminInteractor : IDeleteCategoriaUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<CategoriaUserAdmin,int> _readRepository;
    private readonly IDeleteCategoriaUserAdminOutputPort _outputPort;
    
    public DeleteCategoriaUserAdminInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<CategoriaUserAdmin, int> readRepository,
        IDeleteCategoriaUserAdminOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }
    
    
    public async ValueTask Handle(int categoriaId)
    {
        
        var spec = new CategoriaUserAdminActivoByIdSpecification(categoriaId);

        var categoria = await _readRepository.GetByIdWithSpec(spec);

        if (categoria == null) throw new NotFoundException("La categoria no se encuentra registrada");

        categoria.Activo = false;
        
        _unitOfWork.WriteRepository<CategoriaUserAdmin,int>().UpdateEntity(categoria);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de categorias");
        }

        await _outputPort.Handle(categoria.Id);
    }
}