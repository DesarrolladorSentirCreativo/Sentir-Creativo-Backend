namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Create
{
    public class CreateOcacionInteractor : ICreateOcacionInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateOcacionOutputPort _outputPort;
        private readonly IEnumerable<IValidator<CreateOcacionDto>> _validators;

        public CreateOcacionInteractor(IUnitOfWork unitOfWork,
            ICreateOcacionOutputPort outputPort,
            IEnumerable<IValidator<CreateOcacionDto>> validators)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async ValueTask Handle(CreateOcacionDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<CreateOcacionDto>.Validate(dto, _validators);

            var ocacion = new Ocacion
            {
                Nombre = dto.Nombre,
                PublishedAt = DateTime.Now,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Activo = true
            };

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Ocacion, int>().AddEntity(ocacion);

            //confirmos y guardamos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La Ocacion no se pudo registrar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(ocacion.Id);

        }
    }
}
