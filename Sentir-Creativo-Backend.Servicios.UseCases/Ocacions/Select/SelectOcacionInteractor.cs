namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Select
{
    public class SelectOcacionInteractor : ISelectOcacionInputPort
    {
        private readonly ISelectOcacionOutputPort _outputPort;
        private readonly IReadRepository<Ocacion, int> _readRepository;

        public SelectOcacionInteractor(
            ISelectOcacionOutputPort outputPort, IReadRepository<Ocacion, int> readRepository)
        {
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle()
        {
            var spec = new OcacionActivosSpecification();

            var ocaciones = await _readRepository.GetAllWithSpec(spec);

            IReadOnlyList<SelectOcacionModelView> viewModels = ocaciones
            .Select(p => new SelectOcacionModelView() { Id = p.Id, Nombre = p.Nombre })
            .ToList()
            .AsReadOnly();

            await _outputPort.Handle(viewModels);
        }
    }
}
