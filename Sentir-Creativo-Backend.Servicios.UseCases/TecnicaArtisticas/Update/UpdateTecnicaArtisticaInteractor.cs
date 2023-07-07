namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Update
{
    public class UpdateTecnicaArtisticaInteractor : IUpdateTecnicaArtisticaInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdateTecnicaArtisticaOutputPort _outputPort;
        private readonly IEnumerable<IValidator<UpdateTecnicaArtisticaDto>> _validators;
        private readonly IReadRepository<TecnicaArtistica,int> _readRepository;

        public UpdateTecnicaArtisticaInteractor(
            IUnitOfWork unitOfWork,
            IUpdateTecnicaArtisticaOutputPort outputPort,
            IEnumerable<IValidator<UpdateTecnicaArtisticaDto>> validators, 
            IReadRepository<TecnicaArtistica, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(UpdateTecnicaArtisticaDto dto)
        {
            //validamos los datos (dto)
            await Validator<UpdateTecnicaArtisticaDto>.Validate(dto,_validators);

            //buscamos el tecnica de artista
            var spec = new TecnicaArtisticaByIdActivoSpecification(dto.Id);

            var tecnicaArtistica = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (tecnicaArtistica == null) throw new NotFoundException("La tecnica artistica no se encuentra registrada");

            tecnicaArtistica.Nombre = dto.Nombre;
            tecnicaArtistica.UpdatedBy = dto.UserId;
            tecnicaArtistica.UpdatedAt = DateTime.Now;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<TecnicaArtistica,int>().UpdateEntity(tecnicaArtistica);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La tecnica artistica no se pude actualizar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(tecnicaArtistica.Id);
        }
}
}
