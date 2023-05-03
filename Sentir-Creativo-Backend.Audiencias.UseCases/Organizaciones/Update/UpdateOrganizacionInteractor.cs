using FluentValidation;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Organizaciones.Update;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.DTO.Organizaciones;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.POCOEntities;
using Sentir_Creativo_Backend.Audiencias.Entities.POCOEntities;
using Sentir_Creativo_Backend.Direcciones.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.UseCases.Validators;

namespace Sentir_Creativo_Backend.Audiencias.UseCases.Organizaciones.Update;

public class UpdateOrganizacionInteractor : IUpdateOrganizacionInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Organizacion,int> _organizacionReadRepository;
    private readonly IReadRepository<Direccion,int> _direccionReadRepository;
    private readonly IUpdateOrganizacionOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdateOrganizacionDto>> _validators;

    public UpdateOrganizacionInteractor(IUnitOfWork unitOfWork,
        IReadRepository<Organizacion, int> organizacionReadRepository,
        IReadRepository<Direccion, int> direccionReadRepository,
        IUpdateOrganizacionOutputPort outputPort,
        IEnumerable<IValidator<UpdateOrganizacionDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _organizacionReadRepository = organizacionReadRepository;
        _direccionReadRepository = direccionReadRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    public async ValueTask Handle(UpdateOrganizacionDto dto)
    {
        //validamos los datos
        await Validator<UpdateOrganizacionDto>.Validate(dto, _validators);
        
        //validamos si existe la organización 
        var organizacionUpdate = await _organizacionReadRepository.GetByIdAsync(dto.Id);
        
        if (organizacionUpdate == null) throw new Exception("La organización no se encuentra registrada");

        //actualizamos los datos de la organización
        organizacionUpdate.Nombre = dto.Nombre;
        organizacionUpdate.RubroId = dto.RubroId;
        organizacionUpdate.Facebook = dto.Facebook;
        organizacionUpdate.Instagram = dto.Instagram;
        organizacionUpdate.Website = dto.Website;
        organizacionUpdate.Email = dto.Email;
        organizacionUpdate.Historial = dto.Historial;
        organizacionUpdate.Telefono = dto.Telefono;
        organizacionUpdate.UpdatedAt = DateTime.Now;
        organizacionUpdate.UpdatedBy = dto.UserId;
        
        //buscamos la dirección de la organización
        if (dto.DireccionId != 0)
        {
            var direccionUpdate = await _direccionReadRepository.GetByIdAsync(dto.DireccionId);

            if (direccionUpdate == null) throw new Exception("La dirección no se encuentra registrada");

            direccionUpdate.CiudadId = dto.CiudadId;
            direccionUpdate.RegionId = dto.RegionId;
            direccionUpdate.PaisId = dto.PaisId;
            direccionUpdate.Calle = dto.Calle;
            
            //actualizamos los datos de la dirección
            _unitOfWork.WriteRepository<Direccion>().UpdateEntity(direccionUpdate);
        }
        else
        {
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
            await _unitOfWork.Complete();
            
            
            //asiganmos la direccion para la organizacion
            var organizacionDireccion = new OrganizacionDireccion()
            {
                DireccionId = direccion.Id,
                OrganizacionId = dto.Id,
                Predeterminada = true
            };
            
            //guardamos la dirección para la organizacion
            _unitOfWork.WriteRepository<OrganizacionDireccion>().AddEntity(organizacionDireccion);
        }
        
        //actualizamos los datos de la organización
        _unitOfWork.WriteRepository<Organizacion>().UpdateEntity(organizacionUpdate);

        //confirmamos las trasacciones en la base de datos
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de organizaciones");
        }
        
        await _outputPort.Handle(organizacionUpdate.Id);
    }
}