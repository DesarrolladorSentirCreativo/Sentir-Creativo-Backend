namespace Sentir_Creativo_Backend.Servicios.UseCases.Formatos.Delete
{
    public class DeleteFormatoInteractor : IDeleteFormatoInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeleteFormatoOutputPort _outputPort;
        private readonly IReadRepository<Formato, int> _readRepository;

        public DeleteFormatoInteractor(
            IUnitOfWork unitOfWork, 
            IDeleteFormatoOutputPort outputPort,
            IReadRepository<Formato, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(int formatoId)
        {

            //buscamos el formato
            var spec = new FormatoByIdActivoSpecification(formatoId);

            var formato = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (formato == null) throw new NotFoundException("El formato no se encuentra registrado");

            formato.Activo = false;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Formato, int>().UpdateEntity(formato);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La tecnica artistica no se pudo eliminar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(formato.Id);
        }
    }
}
