namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Update;

public class UpdateColeccionUserAdminInteractor : IUpdateColeccionUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<ColeccionUserAdmin,int> _readRepository;
    private readonly IUpdateColeccionUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateColeccionUserAdminDto>> _validators;

    public UpdateColeccionUserAdminInteractor(IUnitOfWork unitOfWork,
        IReadRepository<ColeccionUserAdmin, int> readRepository,
        IUpdateColeccionUserAdminOutputPort outputPort, 
        IEnumerable<IValidator<UpdateColeccionUserAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateColeccionUserAdminDto dto)
    {
        //validamos los datos
        await Validator<UpdateColeccionUserAdminDto>.Validate(dto, _validators);

        var spec = new ColeccionUserAdminActivoByIdSpecification(dto.Id);

        var coleccionUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (coleccionUserAdmin == null) throw new NotFoundException("La coleccion no se encuentra registrada");

        coleccionUserAdmin.Nombre = dto.Nombre;
        coleccionUserAdmin.ModuloId = dto.ModuloId;
        coleccionUserAdmin.Descripcion = dto.Descripcion;
        coleccionUserAdmin.UpdatedBy = dto.UserId;
        coleccionUserAdmin.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<ColeccionUserAdmin,int>().UpdateEntity(coleccionUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de colecciones");
        }

        await _outputPort.Handle(coleccionUserAdmin.Id);
    }
}