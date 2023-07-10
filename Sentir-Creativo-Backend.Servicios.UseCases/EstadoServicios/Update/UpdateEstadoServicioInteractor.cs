namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Update
{
    public class UpdateEstadoServicioInteractor : IUpdateEstadoServicioInputPort
    {
        private readonly IReadRepository<EstadoServicio, int> _readRepository;
        private readonly ICreateEstadoServicioOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEnumerable<IValidator<UpdateEstadoServicioDto>> _validators;

        public UpdateEstadoServicioInteractor(
            IReadRepository<EstadoServicio, int> readRepository, 
            ICreateEstadoServicioOutputPort outputPort, IUnitOfWork unitOfWork,
            IEnumerable<IValidator<UpdateEstadoServicioDto>> validators)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
            _unitOfWork = unitOfWork;
            _validators = validators;
        }

        public async ValueTask Handle(UpdateEstadoServicioDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<UpdateEstadoServicioDto>.Validate(dto, _validators);

            var specById = new EstadoServicioByIdActivoSpecification(dto.Id);

            var estadoServicio = await _readRepository.GetByIdWithSpec(specById);

            if (estadoServicio == null) throw new NotFoundException("El estado servicio no se encuentra registrado");

            //validamos si existe el color en la tabla
            if (!string.IsNullOrEmpty(dto.Color))
            {
                var spec = new EstadoServicioByColorSpecification(dto.Color);

                var estadoExists = await _readRepository.GetByIdWithSpec(spec);

                if (estadoExists != null)
                {
                    if(estadoExists.Id != estadoServicio.Id) throw new Exception("El estado ya se encuentra registrado");
                    
                }
            }

            estadoServicio.Nombre = dto.Nombre;
            estadoServicio.Color = dto.Color;
            estadoServicio.Descripcion = dto.Descripcion;
            estadoServicio.UpdatedAt = DateTime.Now;
            estadoServicio.UpdatedBy = dto.UserId;

            _unitOfWork.WriteRepository<EstadoServicio, int>().UpdateEntity(estadoServicio);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("El estado de servicio no se pude actualizar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(estadoServicio.Id);
        }
    }
}
