namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetAll
{
    public class GetAllTecnicaArtisticaInteractor : IGetAllTecnicaArtisticaInputPort
    {
        private readonly IGetAllTecnicaArtisticaOutputPort _outputPort;
        private readonly IReadRepository<TecnicaArtistica, int> _readRepository;

        public GetAllTecnicaArtisticaInteractor(
            IGetAllTecnicaArtisticaOutputPort outputPort, 
            IReadRepository<TecnicaArtistica, int> readRepository)
        {
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle()
        {

            //buscamos solo los registrios activos 
            var spec = new TecnicaArtisticaActivosSpecification();

            var tecnicasArtisticas = await _readRepository.GetAllWithSpec(spec);

            //adaptamos los datos a listado que necesita el usuario
            IReadOnlyList<GetAllTecnicaArtisticaViewModel> data = tecnicasArtisticas
           .Select(p =>
               new GetAllTecnicaArtisticaViewModel()
               {
                   Id = p.Id,
                   Nombre = p.Nombre,
                   PublishedAt = p.PublishedAt,

               })
           .ToList()
           .AsReadOnly();

            //mandamos los datos al bus salida
            await _outputPort.Handle(data);
        }
    }
}
