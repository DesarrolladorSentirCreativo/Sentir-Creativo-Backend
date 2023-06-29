namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Create;

public class CreateAcuerdoUserAdminInteractor : ICreateAcuerdoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateAcuerdoUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateAcuerdoUserAdminDto>> _validators;

    public CreateAcuerdoUserAdminInteractor(
        IUnitOfWork unitOfWork, 
        ICreateAcuerdoUserAdminOutputPort outputPort, 
        IEnumerable<IValidator<CreateAcuerdoUserAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(CreateAcuerdoUserAdminDto dto)
    {
        //validamos los datos
        await Validator<CreateAcuerdoUserAdminDto>.Validate(dto, _validators);
        
        var acuerdo = new AcuerdoUserAdmin()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<AcuerdoUserAdmin,int>().AddEntity(acuerdo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de acuerdos");
        }
        
        await _outputPort.Handle(acuerdo.Id);
    }
}