namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.GetById
{
    public class GetByIdEstadoServicioInteractor : IGetByIdEstadoServicioInputPort
    {
        private readonly IReadRepository<EstadoServicio, int> _readRepository;
        private readonly IGetByIdEstadoServicioOutputPort _outputPort;

        public GetByIdEstadoServicioInteractor(
            IReadRepository<EstadoServicio, int> readRepository, 
            IGetByIdEstadoServicioOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle(int estadoServicioId)
        {
            var specById = new EstadoServicioByIdActivoSpecification(estadoServicioId);

            var estadoServicio = await _readRepository.GetByIdWithSpec(specById);

            if (estadoServicio == null) throw new NotFoundException("El estado servicio no se encuentra registrado");

            var viewModel = new GetByIdEstadoServicioViewModel()
            {
                Id = estadoServicio.Id,
                Nombre = estadoServicio.Nombre,
                Color = estadoServicio.Color,
                Descripcion = estadoServicio.Descripcion,
            };

            await _outputPort.Handle(viewModel);
        }
    }
}
