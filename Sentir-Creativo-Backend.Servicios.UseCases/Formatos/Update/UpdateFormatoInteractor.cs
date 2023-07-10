namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Update
{
    public class UpdateFormatoInteractor : IUpdateFormatoInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdateFormatoOutputPort _outputPort;
        private readonly IEnumerable<IValidator<UpdateFormatoDto>> _validators;
        private readonly IReadRepository<Formato, int> _readRepository;

        public UpdateFormatoInteractor(
            IUnitOfWork unitOfWork,
            IUpdateFormatoOutputPort outputPort,
            IEnumerable<IValidator<UpdateFormatoDto>> validators,
            IReadRepository<Formato, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(UpdateFormatoDto dto)
        {
            //validamos los datos (dto)
            await Validator<UpdateFormatoDto>.Validate(dto, _validators);

            //buscamos el formato
            var spec = new FormatoByIdActivoSpecification(dto.Id);

            var formato = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (formato == null) throw new NotFoundException("El formato no se encuentra registrado");

            formato.Nombre = dto.Nombre;
            formato.UpdatedBy = dto.UserId;
            formato.UpdatedAt = DateTime.Now;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Formato, int>().UpdateEntity(formato);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La tecnica artistica no se pude actualizar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(formato.Id);
        }
    }
}
