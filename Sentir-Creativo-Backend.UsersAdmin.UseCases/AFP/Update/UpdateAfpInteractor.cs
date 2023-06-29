namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AFP.Update;

public class UpdateAfpInteractor : IUpdateAfpInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Afp,int> _readRepository;
    private readonly IUpdateAfpOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateAfpDto>> _validators;
    
    public UpdateAfpInteractor(
        IUnitOfWork unitOfWork, IReadRepository<Afp, int> readRepository,
        IUpdateAfpOutputPort outputPort, 
        IEnumerable<IValidator<UpdateAfpDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateAfpDto dto)
    {
        //validamos los datos
        await Validator<UpdateAfpDto>.Validate(dto, _validators);

        var spec = new AfpActivoByIdSpecification(dto.Id);

        var afp = await _readRepository.GetByIdWithSpec(spec);

        if (afp == null) throw new NotFoundException("El afp no se encuentra registrada");

        afp.Nombre = dto.Nombre;
        afp.Descripcion = dto.Descripcion;
        afp.UpdatedBy = dto.UserId; 
        afp.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<Afp,int>().UpdateEntity(afp);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de afp");
        }

        await _outputPort.Handle(afp.Id);
    }
}