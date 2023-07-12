namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Delete
{
    public class DeletePublicoObjetivoInteractor : IDeletePublicoObjetivoInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeletePublicoObjetivoOutputPort _outputPort;
        private readonly IReadRepository<PublicoObjetivo, int> _readRepository;

        public DeletePublicoObjetivoInteractor(
            IUnitOfWork unitOfWork,
            IDeletePublicoObjetivoOutputPort outputPort,
            IReadRepository<PublicoObjetivo, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(int publicoObjetivoId)
        {
            //buscamos el tecnica de artista
            var spec = new PublicoObjetivoByIdActivoSpecification(publicoObjetivoId);

            var publicoObjetivo = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (publicoObjetivo == null) throw new NotFoundException("El publico objetivo no se encuentra registrado");

            publicoObjetivo.Activo = false;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<PublicoObjetivo, int>().UpdateEntity(publicoObjetivo);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("El publico objetivo no se pudo eliminar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(publicoObjetivo.Id);
        }
    }
}
