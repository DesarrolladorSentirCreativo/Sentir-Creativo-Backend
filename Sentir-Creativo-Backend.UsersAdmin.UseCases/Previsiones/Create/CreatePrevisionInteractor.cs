namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Previsiones.Create;

public class CreatePrevisionInteractor : ICreatePrevisionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreatePrevisionOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreatePrevisionDto>> _validators;
    
    public CreatePrevisionInteractor(IUnitOfWork unitOfWork, 
        ICreatePrevisionOutputPort outputPort,
        IEnumerable<IValidator<CreatePrevisionDto>> validators)
    {
        _outputPort = outputPort;
        _unitOfWork = unitOfWork;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreatePrevisionDto dto)
    {
        //validamos los datos
        await Validator<CreatePrevisionDto>.Validate(dto, _validators);
        
        var prevision = new Prevision()
        {
            Nombre = dto.Nombre,
            Descripcion = dto.Descripcion,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId,
            Activo = true
        };
        
        _unitOfWork.WriteRepository<Prevision,int>().AddEntity(prevision);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de prevision");
        }
        
        await _outputPort.Handle(prevision.Id);
    }
}