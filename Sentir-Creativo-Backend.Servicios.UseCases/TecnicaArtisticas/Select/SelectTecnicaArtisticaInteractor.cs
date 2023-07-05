using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Select
{
    public class SelectTecnicaArtisticaInteractor : ISelectTecnicaArtisticaInputPort
    {
        private readonly ISelectTecnicaArtisticaOutputPort _outputPort;
        private readonly IReadRepository<TecnicaArtistica, int> _readRepository;

        public SelectTecnicaArtisticaInteractor(
            ISelectTecnicaArtisticaOutputPort outputPort,
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
            IReadOnlyList<SelectTecnicaArtisticaViewModel> data = tecnicasArtisticas
           .Select(p =>
               new SelectTecnicaArtisticaViewModel()
               {
                   Id = p.Id,
                   Nombre = p.Nombre,

               })
           .ToList()
           .AsReadOnly();

            //mandamos los datos al bus salida
            await _outputPort.Handle(data);
        }
    }
}
