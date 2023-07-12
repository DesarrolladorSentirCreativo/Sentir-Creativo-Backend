namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.GetAll
{
    public class GetAllPublicoObjetivoInteractor : IGetAllPublicoObjetivoInputPort
    {
        private readonly IReadRepository<PublicoObjetivo, int> _readRepository;
        private readonly IGetAllPublicoObjetivoOutputPort _outputPort;

        public GetAllPublicoObjetivoInteractor(
            IReadRepository<PublicoObjetivo, int> readRepository, 
            IGetAllPublicoObjetivoOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle()
        {
            var spec = new PublicoObjetivosActivosSpecification();

            var publicoObjetivos = await _readRepository.GetAllWithSpec(spec);

            IReadOnlyList<GetAllPublicoObjetivoViewModel> viewModels = publicoObjetivos
                .Select(p => new GetAllPublicoObjetivoViewModel() { Id = p.Id, Nombre = p.Nombre, PublishedAt = p.PublishedAt })
                .ToList()
                .AsReadOnly();

            await _outputPort.Handle(viewModels);
        }
    }
}
