namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Create
{
    public class CreateFormatoInteractor : ICreateFormatoInputPort
    {
          
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateFormatoOutputPort _outputPort;
        private readonly IEnumerable<IValidator<CreateFormatoDto>> _validators;

        public CreateFormatoInteractor(
            IUnitOfWork unitOfWork, 
            ICreateFormatoOutputPort outputPort,
            IEnumerable<IValidator<CreateFormatoDto>> validators)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
        }

        public async ValueTask Handle(CreateFormatoDto dto)
        {
            //validamos los datos de entrada (dto)
            await Validator<CreateFormatoDto>.Validate(dto, _validators);

            var formato = new Formato
            {
                Nombre = dto.Nombre,
                PublishedAt = DateTime.Now,
                CreatedBy = dto.UserId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Activo = true
            };

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Formato,int>().AddEntity(formato);

            //confirmos y guardamos
            var result = await _unitOfWork.Complete();
            
            if (result <= 0)
            {
                throw new Exception("El formato no se pude registrar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(formato.Id);
        }
    }
}
