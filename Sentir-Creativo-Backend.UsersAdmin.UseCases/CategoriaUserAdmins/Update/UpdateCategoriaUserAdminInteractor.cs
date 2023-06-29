namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaUserAdmins.Update;

public class UpdateCategoriaUserAdminInteractor : IUpdateCategoriaUserAdminInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<CategoriaUserAdmin,int> _readRepository;
    private readonly IUpdateCategoriaUserAdminOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateCategoriaUserAdminDto>> _validators;
    
    public UpdateCategoriaUserAdminInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<CategoriaUserAdmin, int> readRepository,
        IUpdateCategoriaUserAdminOutputPort outputPort,
        IEnumerable<IValidator<UpdateCategoriaUserAdminDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateCategoriaUserAdminDto dto)
    {
        //validamos los datos
        await Validator<UpdateCategoriaUserAdminDto>.Validate(dto, _validators);

        var spec = new CategoriaUserAdminActivoByIdSpecification(dto.Id);

        var categoria = await _readRepository.GetByIdWithSpec(spec);

        if (categoria == null) throw new NotFoundException("La categoria no se encuentra registrada");

        categoria.Nombre = dto.Nombre;
        categoria.Descripcion = dto.Descripcion;
        categoria.UpdatedBy = dto.UserId;
        categoria.UpdatedAt = DateTime.Now;
        
        _unitOfWork.WriteRepository<CategoriaUserAdmin,int>().UpdateEntity(categoria);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de categorias");
        }

        await _outputPort.Handle(categoria.Id);
    }
}