namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.AcuerdosUserAdmin.Update;

public class UpdateAcuerdoUserAdminInteractor : IUpdateAcuerdoUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<AcuerdoUserAdmin,int> _readRepository;
    private readonly IUpdateAcuerdoUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateAcuerdoUserAdminDto>> _validators;

    public UpdateAcuerdoUserAdminInteractor(
        IUnitOfWork unitOfWork, 
        IReadRepository<AcuerdoUserAdmin, int> readRepository,
        IUpdateAcuerdoUserAdminOutputPort outputPort,
        IEnumerable<IValidator<UpdateAcuerdoUserAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }

    public async ValueTask Handle(UpdateAcuerdoUserAdminDto dto)
    {
        //validamos los datos
        await Validator<UpdateAcuerdoUserAdminDto>.Validate(dto, _validators);

        var spec = new AcuerdoUserAdminActivoByIdSpecification(dto.Id);

        var acuerdo = await _readRepository.GetByIdWithSpec(spec);

        if (acuerdo == null) throw new Exception("El acuerdo no se encuentra registrada");

        acuerdo.Nombre = dto.Nombre;
        acuerdo.Descripcion = dto.Descripcion;
        acuerdo.UpdatedBy = dto.UserId;
        acuerdo.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<AcuerdoUserAdmin,int>().UpdateEntity(acuerdo);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de acuerdos");
        }

        await _outputPort.Handle(acuerdo.Id);
    }
}