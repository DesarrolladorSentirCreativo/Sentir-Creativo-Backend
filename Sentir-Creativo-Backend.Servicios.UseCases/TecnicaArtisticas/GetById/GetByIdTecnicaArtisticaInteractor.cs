using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Specifications.TecnicaArtisticas;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;
using Sentir_Creativo_Backend.Servicios.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;
using Sentir_Creativo_Backend.SharedKernel.Entities.Exceptions;

namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.GetById
{
    public class GetByIdTecnicaArtisticaInteractor : IGetByIdTecnicaArtisticaInputPort
    {
        private readonly IGetByIdTecnicaArtisticaOutputPort _outputPort;
        private readonly IReadRepository<TecnicaArtistica, int> _readRepository;

        public GetByIdTecnicaArtisticaInteractor(
            IGetByIdTecnicaArtisticaOutputPort outputPort,
            IReadRepository<TecnicaArtistica, int> readRepository)
        {
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

            //adaptamos los datos a lo que necesita el usuario
            var modelView = new GetByIdTecnicaArtisticaViewModel
            {
                Id = tecnicaArtistica.Id,
                Nombre = tecnicaArtistica.Nombre,
                PublishedAt = tecnicaArtistica.PublishedAt
            };

            //mandamos los datos al bus de salida
            await _outputPort.Handle(modelView);
        }
    }
}
