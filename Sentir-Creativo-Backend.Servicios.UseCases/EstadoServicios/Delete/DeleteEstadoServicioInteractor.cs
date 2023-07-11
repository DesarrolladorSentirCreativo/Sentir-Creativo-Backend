namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.Delete
{
    public class DeleteEstadoServicioInteractor : IDeleteEstadoServicioInputPort
    {
        private readonly IReadRepository<EstadoServicio, int> _readRepository;
        private readonly IDeleteEstadoServicioOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteEstadoServicioInteractor(
            IReadRepository<EstadoServicio, int> readRepository,
            IDeleteEstadoServicioOutputPort outputPort,
            IUnitOfWork unitOfWork)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
            _unitOfWork = unitOfWork;
        }

        public async ValueTask Handle(int estadoServicioId)
        {
        
            var specById = new EstadoServicioByIdActivoSpecification(estadoServicioId);

            var estadoServicio = await _readRepository.GetByIdWithSpec(specById);

            if (estadoServicio == null) throw new NotFoundException("El estado servicio no se encuentra registrado");

            estadoServicio.Activo = false;

            _unitOfWork.WriteRepository<EstadoServicio, int>().UpdateEntity(estadoServicio);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("El estado de servicio no se pude eliminar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(estadoServicio.Id);
        }
    }
}
