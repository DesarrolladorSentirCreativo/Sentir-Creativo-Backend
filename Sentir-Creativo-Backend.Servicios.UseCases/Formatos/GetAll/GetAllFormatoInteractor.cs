namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.GetAll
{
    public class GetAllFormatoInteractor : IGetAllFormatoInputPort
    {
        private readonly IReadRepository<Formato, int> _readRepository;
        private readonly IGetAllFormatoOutputPort _outputPort;

        public GetAllFormatoInteractor(
            IReadRepository<Formato, int> readRepository,
            IGetAllFormatoOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle()
        {
            var spec = new FormatoActivosSpecification();

            var formatos = await _readRepository.GetAllWithSpec(spec);

            IReadOnlyList<GetAllFormatoViewModel> viewModels = formatos
                .Select(p => new GetAllFormatoViewModel() { Id = p.Id, Nombre = p.Nombre, PublishedAt = p.PublishedAt })
                .ToList()
                .AsReadOnly();

            await _outputPort.Handle(viewModels);
        }
    }
}
