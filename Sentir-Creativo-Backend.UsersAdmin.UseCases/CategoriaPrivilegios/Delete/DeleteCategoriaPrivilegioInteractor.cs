namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Delete;

public class DeleteCategoriaPrivilegioInteractor : IDeleteCategoriaPrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<CategoriaPrivilegio,int> _readRepository;
    private readonly IDeleteCategoriaPrivilegioOutputPort _outputPort;

    public DeleteCategoriaPrivilegioInteractor(
        IUnitOfWork unitOfWork, IReadRepository<CategoriaPrivilegio, int> readRepository,
        IDeleteCategoriaPrivilegioOutputPort outputPort)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
    }

    public async ValueTask Handle(int categoriaPrivilegioId)
    {
        var spec = new CategoriaPrivilegioActivoByIdSpecification(categoriaPrivilegioId);

        var categoriaPrivilegio = await _readRepository.GetByIdWithSpec(spec);

        if (categoriaPrivilegio == null) throw new NotFoundException("La categoria privilegio no se encuentra registrada");

        categoriaPrivilegio.Activo = false;
        
        _unitOfWork.WriteRepository<CategoriaPrivilegio,int>().UpdateEntity(categoriaPrivilegio);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de categorias privilegios");
        }

        await _outputPort.Handle(categoriaPrivilegio.Id);
    }
}