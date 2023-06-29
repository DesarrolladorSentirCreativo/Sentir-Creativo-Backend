namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.ColeccionesUserAdmin.Create;

public class CreateColeccionUserAdminInteractor : ICreateColeccionUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateColeccionUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateColeccionUserAdminDto>> _validators;
    
    public CreateColeccionUserAdminInteractor(IUnitOfWork unitOfWork, 
        ICreateColeccionUserAdminOutputPort outputPort,
        IEnumerable<IValidator<CreateColeccionUserAdminDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    
    public async ValueTask Handle(CreateColeccionUserAdminDto dto)
    {
        //validamos los datos
        await Validator<CreateColeccionUserAdminDto>.Validate(dto, _validators);
        
        var coleccionUserAdmin = new ColeccionUserAdmin()
        {
            Nombre = dto.Nombre,
            ModuloId = dto.ModuloId,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<ColeccionUserAdmin,int>().AddEntity(coleccionUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de colecciones");
        }
        
        await _outputPort.Handle(coleccionUserAdmin.Id);
    }
}