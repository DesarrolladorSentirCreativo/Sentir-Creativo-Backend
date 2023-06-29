namespace Sentir_Creativo_Backend.UsersAdmin.UseCases.Privilegios.Update;

public class UpdatePrivilegioInteractor : IUpdatePrivilegioInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Privilegio,string> _privilegioReadRepository;
    private readonly IReadRepository<PrivilegioAcceso, int> _privilegioAccesoReadRepository;
    private readonly IUpdatePrivilegioOutputPort _outputPort;
    private readonly IEnumerable<IValidator<UpdatePrivilegioDto>> _validators;

    public UpdatePrivilegioInteractor(IUnitOfWork unitOfWork,
        IReadRepository<Privilegio,string> privilegioReadRepository,
        IReadRepository<PrivilegioAcceso,int> privilegioAccesoReadRepository,
        IUpdatePrivilegioOutputPort outputPort,
        IEnumerable<IValidator<UpdatePrivilegioDto>> validators)
    {
        _unitOfWork = unitOfWork;
        _privilegioReadRepository = privilegioReadRepository;
        _privilegioAccesoReadRepository = privilegioAccesoReadRepository;
        _outputPort = outputPort;
        _validators = validators;
    }
    
    
    public async ValueTask Handle(UpdatePrivilegioDto dto)
    {
        //validamos los datos
        await Validator<UpdatePrivilegioDto>.Validate(dto, _validators);

        var spec = new PrivilegioActivoByIdSpecification(dto.Id);

        var privilegio = await _privilegioReadRepository.GetByIdWithSpec(spec);

        if (privilegio == null) throw new NotFoundException("El privilegio no se encuentra registrado");

        privilegio.Nombre = dto.Nombre;
        privilegio.CategoriaId = dto.CategoriaId;
        privilegio.Descripcion = dto.Descripcion;
        privilegio.UpdatedAt = DateTime.Now;
        privilegio.UpdatedBy = dto.UserId;

        _unitOfWork.WriteRepository<Privilegio,string>().UpdateEntity(privilegio);
        
        var privilegioAccesoSpec = new PrivilegioAccesoByPrivilegioIdSpecification(privilegio.Id);
        
        //buscanos los accesos del privilegio
        var privilegiosAccesos = await _privilegioAccesoReadRepository.GetAllWithSpec(privilegioAccesoSpec);

        //eliminamos los accesos antiguos
        foreach (var privilegioAcceso in privilegiosAccesos)
        {
            _unitOfWork.WriteRepository<Acceso,string>().DeleteWhere(x => x.Id == privilegioAcceso.AccesoId);
        }
        
        //eliminamos los privilegios accesos
        _unitOfWork.WriteRepository<PrivilegioAcceso,int>().DeleteWhere(x => x.PrivilegioId == privilegio.Id);
        
        
        List<string> accesoIds = new List<string>();
        
        //guardamos todos los accesos de la audiencia
        foreach (var acceso in dto.Accesos)
        {
            Guid uuid = Guid.NewGuid();
            
            var newAcceso = new Acceso()
            {
                Id = uuid.ToString(),
                Crear = acceso.Crear,
                Actualizar = acceso.Actualizar,
                Eliminar = acceso.Eliminar,
                ColeccionId = acceso.ColeccionId,
                Ver = acceso.Ver,
                Listar = acceso.Listar,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now
            };
            
            _unitOfWork.WriteRepository<Acceso,string>().AddEntity(newAcceso);
            
            // Guardar el ID del acceso insertado en la lista
            accesoIds.Add(newAcceso.Id);
            
        }
        
        //creamos los accesos del privilegio
        for (int i = 0; i < accesoIds.Count; i++)
        {
            string accesoId = accesoIds[i];

            var privilegioAcceso = new PrivilegioAcceso()
            {
                AccesoId = accesoId,
                PrivilegioId = privilegio.Id,
            };
            
            _unitOfWork.WriteRepository<PrivilegioAcceso,int>().AddEntity(privilegioAcceso);
        }
        
        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo actualizar el record de privilegios");
        }

        await _outputPort.Handle(privilegio.Id);
    }
}