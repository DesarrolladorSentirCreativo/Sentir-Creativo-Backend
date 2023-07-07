namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.GetById
{
    public class GetByIdOcacionInteractor : IGetByIdOcacionInputPort
    {
        private readonly IGetByIdOcacionOutputPort _outputPort;
        private readonly IReadRepository<Ocacion, int> _readRepository;

        public GetByIdOcacionInteractor(
            IGetByIdOcacionOutputPort outputPort, IReadRepository<Ocacion, int> readRepository)
        {
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(int ocacionId)
        {
            var spec = new OcacionByIdSpecification(ocacionId);

            var ocacion = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (ocacion == null) throw new NotFoundException("La ocacion artistica no se encuentra registrada");

            var viewModel = new GetByIdOcacionViewModel
            {
                Id = ocacion.Id,
                Nombre = ocacion.Nombre,
            };

            await _outputPort.Handle(viewModel);
        }
    }
}
