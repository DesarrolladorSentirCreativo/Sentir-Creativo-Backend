namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Create
{
    public class CreatePublicoObjetivoInteractor : ICreatePublicoObjetivoInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreatePublicoObjetivoOutputPort _outputPort;
        private readonly IEnumerable<IValidator<CreatePublicoObjetivoDto>> _validators;

        public CreatePublicoObjetivoInteractor(
            IUnitOfWork unitOfWork,
            ICreatePublicoObjetivoOutputPort outputPort,
            IEnumerable<IValidator<CreatePublicoObjetivoDto>> validators)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async ValueTask Handle(CreatePublicoObjetivoDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<CreatePublicoObjetivoDto>.Validate(dto, _validators);

            var publicoObjetivo = new PublicoObjetivo
            {
                Nombre = dto.Nombre,
                PublishedAt = DateTime.Now,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Activo = true
            };

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<PublicoObjetivo, int>().AddEntity(publicoObjetivo);

            //confirmos y guardamos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("El publico objetivo no se pudo registrar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(publicoObjetivo.Id);
        }
    }
}
