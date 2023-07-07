namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.GetAll
{
    public class GetAllOcacionInteractor : IGetAllOcacionInputPort
    {
        private readonly IGetAllOcacionOutputPort _outputPort;
        private readonly IReadRepository<Ocacion, int> _readRepository;

        public GetAllOcacionInteractor( 
            IGetAllOcacionOutputPort outputPort,
            IReadRepository<Ocacion, int> readRepository)
        {
          
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle()
        {
            var spec = new OcacionActivosSpecification();

            var ocaciones = await _readRepository.GetAllWithSpec(spec);

            IReadOnlyList<GetAllOcacionViewModel> viewModels = ocaciones
            .Select(p => new GetAllOcacionViewModel() { Id = p.Id, Nombre = p.Nombre, PublishedAt = p.PublishedAt  })
            .ToList()
            .AsReadOnly();

            await _outputPort.Handle(viewModels);
        }
    }
}
