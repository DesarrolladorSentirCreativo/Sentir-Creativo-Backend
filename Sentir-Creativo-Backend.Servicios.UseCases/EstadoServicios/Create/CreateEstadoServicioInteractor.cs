namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Create
{
    public class CreateEstadoServicioInteractor : ICreateEstadoServicioInputPort
    {
        private readonly IReadRepository<EstadoServicio, int> _readRepository;
        private readonly ICreateEstadoServicioOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEnumerable<IValidator<CreateEstadoServicioDto>> _validators;

        public CreateEstadoServicioInteractor(
            IReadRepository<EstadoServicio, int> readRepository, 
            ICreateEstadoServicioOutputPort outputPort, IUnitOfWork unitOfWork,
            IEnumerable<IValidator<CreateEstadoServicioDto>> validators)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
            _unitOfWork = unitOfWork;
            _validators = validators;
        }

        public async ValueTask Handle(CreateEstadoServicioDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<CreateEstadoServicioDto>.Validate(dto, _validators);

            //validamos si existe el color en la tabla
            if (!string.IsNullOrEmpty(dto.Color))
            {
                var spec = new EstadoServicioByColorSpecification(dto.Color);

                var estadoExists = await _readRepository.GetByIdWithSpec(spec);

                if (estadoExists != null) throw new Exception("El estado ya se encuentra registrado");
            }

            var estadoServicio = new EstadoServicio
            {
                Nombre = dto.Nombre,
                Color = dto.Color,
                Descripcion = dto.Descripcion,
                Activo = true,
                PublishedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
                CreatedBy = dto.UserId,
            };

            //se crea el estado de servicios
            _unitOfWork.WriteRepository<EstadoServicio,int>().AddEntity(estadoServicio);

            var result = await _unitOfWork.Complete();


            if (result <= 0)
            {
                throw new Exception("El estado de servicio no se pudo registrar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(estadoServicio.Id);
        }
    }
}
