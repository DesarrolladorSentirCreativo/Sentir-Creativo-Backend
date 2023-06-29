namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Create;

public class CreateCategoriaUserAdminInteractor : ICreateCategoriaUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateCategoriaUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateCategoriaUserAdminDto>> _validators;
    
    public CreateCategoriaUserAdminInteractor(IUnitOfWork unitOfWork, 
        ICreateCategoriaUserAdminOutputPort outputPort,
        IEnumerable<IValidator<CreateCategoriaUserAdminDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateCategoriaUserAdminDto dto)
    {
        //validamos los datos
        await Validator<CreateCategoriaUserAdminDto>.Validate(dto, _validators);
        
        var categoria = new CategoriaUserAdmin()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<CategoriaUserAdmin,int>().AddEntity(categoria);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de categorias useradmins");
        }
        
        await _outputPort.Handle(categoria.Id);
    }
}