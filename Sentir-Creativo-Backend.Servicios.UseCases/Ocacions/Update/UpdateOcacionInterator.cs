namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Update
{
    public class UpdateOcacionInterator : IUpdateOcacionInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdateOcacionOutputPort _outputPort;
        private readonly IEnumerable<IValidator<UpdateOcacionDto>> _validators;
        private readonly IReadRepository<Ocacion, int> _readRepository;

        public UpdateOcacionInterator(
            IUnitOfWork unitOfWork,
            IUpdateOcacionOutputPort outputPort,
            IEnumerable<IValidator<UpdateOcacionDto>> validators,
            IReadRepository<Ocacion, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(UpdateOcacionDto dto)
        {
            await Validator<UpdateOcacionDto>.Validate(dto, _validators);

            //
            var spec = new OcacionByIdSpecification(dto.Id);

            var ocacion = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (ocacion == null) throw new NotFoundException("La ocacion artistica no se encuentra registrada");

            ocacion.Nombre = dto.Nombre;
            ocacion.UpdatedBy = dto.UserId;
            ocacion.UpdatedAt = DateTime.Now;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Ocacion, int>().UpdateEntity(ocacion);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La Ocacion no se pude actualizar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(ocacion.Id);
        }
        }
    }

