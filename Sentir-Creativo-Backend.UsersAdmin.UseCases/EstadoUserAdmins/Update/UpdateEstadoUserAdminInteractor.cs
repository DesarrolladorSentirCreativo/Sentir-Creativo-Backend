namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.EstadoUserAdmins.Update;

public class UpdateEstadoUserAdminInteractor : IUpdateEstadoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUpdateEstadoUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateEstadoUserAdminDto>> _validators;
    private readonly IReadRepository<EstadoUserAdmin, int> _readRepository;
    
    public UpdateEstadoUserAdminInteractor(IUnitOfWork unitOfWork, 
        IUpdateEstadoUserAdminOutputPort outputPort,
        IEnumerable<IValidator<UpdateEstadoUserAdminDto>> validators,
        IReadRepository<EstadoUserAdmin, int> readRepository)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle(UpdateEstadoUserAdminDto dto)
    {
        //validamos los datos
        await Validator<UpdateEstadoUserAdminDto>.Validate(dto, _validators);

        var spec = new EstadoUserAdminActivoByIdSpecification(dto.Id);

        var estadoUserAdmin = await _readRepository.GetByIdWithSpec(spec);

        if (estadoUserAdmin == null) throw new NotFoundException("El estado de useradmin no se encuentra registrado");

        //evaluo si el color cambio
        if (estadoUserAdmin.Color != dto.Color)
        {
            //validamos si el color no esta registrado en otro estado de useradmin
            var specColor = new EstadoUserAdminActivoByColorSpecification(dto.Color);

            var estadoUserAdminColor = await _readRepository.GetByIdWithSpec(specColor);
            
            if(estadoUserAdminColor != null) throw new Exception("El color ya se encuentra registrado");
        }

        estadoUserAdmin.Nombre = dto.Nombre;
        estadoUserAdmin.Color = dto.Color;
        estadoUserAdmin.Descripcion = dto.Descripcion;
        estadoUserAdmin.UpdatedBy = dto.UserId; 
        estadoUserAdmin.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<EstadoUserAdmin,int>().UpdateEntity(estadoUserAdmin);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de estados useradmins");
        }

        await _outputPort.Handle(estadoUserAdmin.Id);
    }
}