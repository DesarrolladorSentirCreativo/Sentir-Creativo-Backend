namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Create;

public class CreateCategoriaPrivilegioInteractor : ICreateCategoriaPrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateCategoriaPrivilegioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateCategoriaPrivilegioDto>> _validators;

    public CreateCategoriaPrivilegioInteractor(
        IUnitOfWork unitOfWork,
        ICreateCategoriaPrivilegioOutputPort outputPort,
        IEnumerable<IValidator<CreateCategoriaPrivilegioDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateCategoriaPrivilegioDto dto)
    {
        //validamos los datos
        await Validator<CreateCategoriaPrivilegioDto>.Validate(dto, _validators);
        
        var categoriaPrivilegio = new CategoriaPrivilegio()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<CategoriaPrivilegio,int>().AddEntity(categoriaPrivilegio);
        
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de categorias privilegios");
        }
        
        await _outputPort.Handle(categoriaPrivilegio.Id);

    }
}