namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.GetById
{
    public class GetByIdPublicoObjetivoInteractor : IGetByIdPublicoObjetivoInputPort
    {
        private readonly IReadRepository<PublicoObjetivo, int> _readRepository;
        private readonly IGetByIdPublicoObjetivoOutputPort _outputPort;

        public GetByIdPublicoObjetivoInteractor(IReadRepository<PublicoObjetivo, int> readRepository, IGetByIdPublicoObjetivoOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle(int publicoObjetivoId)
        {
            //buscamos el tecnica de artista
            var spec = new PublicoObjetivoByIdActivoSpecification(publicoObjetivoId);

            var publicoObjetivo = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (publicoObjetivo == null) throw new NotFoundException("El publico objetivo no se encuentra registrado");

            var viewModel = new GetByIdPublicoObjetivoViewModel
            {
                Id = publicoObjetivo.Id,
                Nombre = publicoObjetivo.Nombre
            };

            await _outputPort.Handle(viewModel);
        }
    }
}
