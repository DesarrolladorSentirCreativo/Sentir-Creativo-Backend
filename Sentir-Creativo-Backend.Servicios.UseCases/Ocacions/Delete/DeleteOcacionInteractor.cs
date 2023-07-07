using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Delete;

namespace Sentir_Creativo_Backend.Servicios.UseCases.Ocacions.Delete
{
    public class DeleteOcacionInteractor : IDeleteOcacionInputPort
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IUpdateOcacionOutputPort _outputPort;
        private readonly IReadRepository<Ocacion, int> _readRepository;

        public DeleteOcacionInteractor(
            IUnitOfWork unitOfWork, 
            IUpdateOcacionOutputPort outputPort, 
            IReadRepository<Ocacion, int> readRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _readRepository = readRepository;
        }

        public async ValueTask Handle(int ocacionId)
        {
        
            //buscamos el registro por su id
            var spec = new OcacionByIdSpecification(ocacionId);

            var ocacion = await _readRepository.GetByIdWithSpec(spec);

            //validamos si lo encontro
            if (ocacion == null) throw new NotFoundException("La ocacion no se encuentra registrada");

            ocacion.Activo = false;

            //guardamos en la base de datos
            _unitOfWork.WriteRepository<Ocacion, int>().UpdateEntity(ocacion);

            //confirmamos los datos
            var result = await _unitOfWork.Complete();

            if (result <= 0)
            {
                throw new Exception("La Ocacion no se pudo eliminar");
            }

            //MANDAMOS EL ID CON EL BUS DE SALIDA
            await _outputPort.Handle(ocacion.Id);

        }
    }
}
