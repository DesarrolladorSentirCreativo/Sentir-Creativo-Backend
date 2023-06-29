namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.Create;

public class CreateEstadoUserAdminInteractor : ICreateEstadoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateEstadoUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateEstadoUserAdminDto>> _validators;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;

    public CreateEstadoUserAdminInteractor(IUnitOfWork unitOfWork, 
        ICreateEstadoUserAdminOutputPort outputPort,
        IEnumerable<IValidator<CreateEstadoUserAdminDto>> validators,
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle(CreateEstadoUserAdminDto dto)
    {
        //validamos los datos
        await Validator<CreateEstadoUserAdminDto>.Validate(dto, _validators);

        var spec = new EstadoUserAdminActivoByColorSpecification(dto.Color);

        var existEstadoUserAdmin = await _readRepository.GetByIdWithSpec(spec);
        
        //validamos que el color no se encuentre registrado
        if(existEstadoUserAdmin != null) throw new Exception("Ya existe un estado con ese color");
        
        //creamos el estado
        var estadoUserAdmin = new EstadoUserAdmin()
        {
            Nombre = dto.Nombre,
            Color = dto.Color,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<EstadoUserAdmin,int>().AddEntity(estadoUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de estados user admin");
        }
        
        await _outputPort.Handle(estadoUserAdmin.Id);
    }
}