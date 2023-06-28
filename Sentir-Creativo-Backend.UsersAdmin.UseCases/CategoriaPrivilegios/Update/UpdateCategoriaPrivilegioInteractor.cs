using FluentValidation;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Specifications.CategoriaPrivilegios;
using Sentir_Creativo_Backend.UsersAdmin.Entities.POCOEntities;

namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.CategoriaPrivilegios.Update;

public class UpdateCategoriaPrivilegioInteractor : IUpdateCategoriaPrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<CategoriaPrivilegio,int> _readRepository;
    private readonly IUpdateCategoriaPrivilegioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateCategoriaPrivilegioDto>> _validators;

    public UpdateCategoriaPrivilegioInteractor(
        IUnitOfWork unitOfWork,
        IReadRepository<CategoriaPrivilegio, int> readRepository,
        IUpdateCategoriaPrivilegioOutputPort outputPort,
        IEnumerable<IValidator<UpdateCategoriaPrivilegioDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _readRepository = readRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateCategoriaPrivilegioDto dto)
    {
        //validamos los datos
        await Validator<UpdateCategoriaPrivilegioDto>.Validate(dto, _validators);

        var spec = new CategoriaPrivilegioActivoByIdSpecification(dto.Id);

        var categoriaPrivilegio = await _readRepository.GetByIdWithSpec(spec);

        if (categoriaPrivilegio == null) throw new NotFoundException("La categoria privilegio no se encuentra registrada");
        
        categoriaPrivilegio.Nombre = dto.Nombre;
        categoriaPrivilegio.Descripcion = dto.Descripcion;
        categoriaPrivilegio.UpdatedAt = DateTime.Now;
        categoriaPrivilegio.UpdatedBy = dto.UserId;
        
        _unitOfWork.WriteRepository<CategoriaPrivilegio,int>().UpdateEntity(categoriaPrivilegio);
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de categorias privilegios");
        }

        await _outputPort.Handle(categoriaPrivilegio.Id);
    }
}