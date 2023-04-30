using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Create;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Create;

public class CreateOrganizacionInteractor : ICreateOrganizacionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICreateOrganizacionOutputPort _outputPort;
    private readonly IEnumerable<IValidator<CreateOrganizacionDto>> _validators;

    public CreateOrganizacionInteractor(IUnitOfWork unitOfWork,
        ICreateOrganizacionOutputPort outputPort,
        IEnumerable<IValidator<CreateOrganizacionDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(CreateOrganizacionDto dto)
    {
        //validamos los datos
        await Validator<CreateOrganizacionDto>.Validate(dto, _validators);

        var organizacion = new Organizacion()
        {
            Nombre = dto.Nombre,
            RubroId = dto.RubroId,
            Facebook = dto.Facebook,
            Instagram = dto.Instagram,
            Website = dto.Website,
            Email = dto.Email,
            Historial = dto.Historial,  
            Telefono = dto.Telefono,
            Activo = true,
            PublishedAt = DateTime.Now,
            CreatedAt = DateTime.Now,
            CreatedBy = dto.UserId
        };
        
        //guardamos la organizacion en la base de datos
        _unitOfWork.WriteRepository<Organizacion>().AddEntity(organizacion);

        var direccion = new Direccion()
        {
            PaisId = dto.PaisId,
            RegionId = dto.RegionId,
            CiudadId = dto.CiudadId,
            Calle = dto.Calle,
            Activo = true,
        };
        
        //guardamos la dirección en la base de datos
        _unitOfWork.WriteRepository<Direccion>().AddEntity(direccion);
        
        //asiganmos la direccion para la organizacion
        var organizacionDireccion = new OrganizacionDireccion()
        {
            DireccionId = direccion.Id,
            OrganizacionId = organizacion.Id,
            Predeterminada = true
        };
        
        //guardamos la dirección para la organizacion
        _unitOfWork.WriteRepository<OrganizacionDireccion>().AddEntity(organizacionDireccion);
        
        //confirmamos los cambios en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo insertar el record de organizaciones");
        }
        
        await _outputPort.Handle(organizacion.Id);
    }
}