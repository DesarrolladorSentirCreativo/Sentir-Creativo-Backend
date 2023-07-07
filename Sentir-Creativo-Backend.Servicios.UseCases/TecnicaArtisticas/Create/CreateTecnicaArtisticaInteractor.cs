namespace Sentir_Creativo_Backend.Servicios.UseCases.TecnicaArtisticas.Create
{
    public class CreateTecnicaArtisticaInteractor : ICreateTecnicaArtisticaInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateTecnicaArtisticaOutputPort _outputPort;
        private readonly IEnumerable<IValidator<ICreateOcacionDto>> _validators;

        public CreateTecnicaArtisticaInteractor(
            IUnitOfWork unitOfWork, 
            ICreateTecnicaArtisticaOutputPort outputPort, 
            IEnumerable<IValidator<ICreateOcacionDto>> validators)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async ValueTask Handle(ICreateOcacionDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<ICreateOcacionDto>.Validate(dto, _validators);

            var tecnicaArtistica = new TecnicaArtistica
            {
                Nombre = dto.Nombre,
                PublishedAt = DateTime.Now,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Activo = true
            };

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<TecnicaArtistica, int>().AddEntity(tecnicaArtistica);

            //confirmos y guardamos
            var result = await _unitOfWork.Complete();

            if(result <= 0)
            {
                throw new Exception("La tecnica artistica no se pude registrar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(tecnicaArtistica.Id);

        }
    }
}
