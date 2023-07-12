namespace Sentir_Creativo_Backend.PublicoObjetivos.UseCases.PublicoObjetivos.Update
{
    public class UpdatePublicoObjetivoInteractor : IUpdatePublicoObjetivoInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdatePublicoObjetivoOutputPort _outputPort;
        private readonly IEnumerable<IValidator<UpdatePublicoObjetivoDto>> _validators;
        private readonly IReadRepository<PublicoObjetivo, int> _readRepository;

        public UpdatePublicoObjetivoInteractor(
            IUnitOfWork unitOfWork,
            IUpdatePublicoObjetivoOutputPort outputPort,
            IEnumerable<IValidator<UpdatePublicoObjetivoDto>> validators,
            IReadRepository<PublicoObjetivo, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _validators = validators;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(UpdatePublicoObjetivoDto dto)
        {
            //validamos los datos (dto)
            await Validator<UpdatePublicoObjetivoDto>.Validate(dto, _validators);

            //buscamos el tecnica de artista
            var spec = new PublicoObjetivoByIdActivoSpecification(dto.Id);

            var publicoObjetivo = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (publicoObjetivo == null) throw new NotFoundException("El publico objetivo no se encuentra registrado");

            publicoObjetivo.Nombre = dto.Nombre;
            publicoObjetivo.UpdatedBy = dto.UserId;
            publicoObjetivo.UpdatedAt = DateTime.Now;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<PublicoObjetivo, int>().UpdateEntity(publicoObjetivo);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("El publico objetivo no se pude actualizar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(publicoObjetivo.Id);
        }
    }
}
