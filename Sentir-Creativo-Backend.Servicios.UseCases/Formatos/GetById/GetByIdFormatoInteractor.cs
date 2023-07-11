namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.GetById
{
    public class GetByIdFormatoInteractor : IGetByIdFormatoInputPort
    {
        private readonly IReadRepository<Formato, int> _readRepository;
        private readonly IGetByIdFormatoOutputPort _outputPort;

        public GetByIdFormatoInteractor(IReadRepository<Formato, int> readRepository, IGetByIdFormatoOutputPort outputPort)
        {
            _readRepository = readRepository;
            _outputPort = outputPort;
        }

        public async ValueTask Handle(int formatoId)
        {
            //buscamos el formato
            var spec = new FormatoByIdActivoSpecification(formatoId);

            var formato = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (formato == null) throw new NotFoundException("El formato no se encuentra registrado");

            var viewModel = new GetByIdFormatoViewModel
            {
                Id = formato.Id,
                Nombre = formato.Nombre,
            };

            await _outputPort.Handle(viewModel);
        }
    }
}
