namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Delete
{
    public class DeleteTecnicaArtisticaInteractor : IDeleteTecnicaArtisticaInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeleteTecnicaArtisticaOutputPort _outputPort;
        private readonly IReadRepository<TecnicaArtistica, int> _readRepository;

        public DeleteTecnicaArtisticaInteractor(
            IUnitOfWork unitOfWork,
            IDeleteTecnicaArtisticaOutputPort outputPort, 
            IReadRepository<TecnicaArtistica, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(int tecnicaArtisticaId)
        {
            //buscamos el tecnica de artista
            var spec = new TecnicaArtisticaByIdActivoSpecification(tecnicaArtisticaId);

            var tecnicaArtistica = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (tecnicaArtistica == null) throw new NotFoundException("La tecnica artistica no se encuentra registrada");

            tecnicaArtistica.Activo = false;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<TecnicaArtistica, int>().UpdateEntity(tecnicaArtistica);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La tecnica artistica no se pudo eliminar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(tecnicaArtistica.Id);
        }
    }
}
