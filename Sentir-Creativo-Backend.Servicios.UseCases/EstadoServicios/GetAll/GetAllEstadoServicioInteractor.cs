namespace Sentir_Creativo_Backend.Servicios.UseCases.EstadoServicios.GetAll
{
    public class GetAllEstadoServicioInteractor : IGetAllEstadoServicioInputPort
    {
        private readonly IReadRepository<EstadoServicio, int> _readRepository;
        private readonly IGetAllEstadoServicioOutputPort _outputPort;

        public GetAllEstadoServicioInteractor(
            IReadRepository<EstadoServicio, int> readRepository,
            IGetAllEstadoServicioOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle() 
        { 
            var spec = new EstadoServicioActivosSpecification();
            var estadoServicios = await _readRepository.GetAllWithSpec(spec);

            IReadOnlyList<GetAllEstadoServicioViewModel> viewModels = estadoServicios
                .Select(p => new GetAllEstadoServicioViewModel()
                {
                   Id = p.Id,
                   Nombre = p.Nombre,
                   Color = p.Color,
                   Descripcion = p.Descripcion,
                   PublishedAt = p.PublishedAt,
                })
                .ToList()
                .AsReadOnly();

            await _outputPort.Handle(viewModels);
        }
    }
}
