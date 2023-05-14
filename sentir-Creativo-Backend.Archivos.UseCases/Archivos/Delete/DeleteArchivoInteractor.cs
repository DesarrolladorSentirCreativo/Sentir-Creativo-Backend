using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;
using Sentir_Creativo_Backend.Archivos.Entities.POCOEntities;
using Sentir_Creativo_Backend.SharedKernel.Entities.Contracts;

namespace sentir_Creativo_Backend.Archivos.UseCases.Archivos.Delete;

public class DeleteArchivoInteractor : IDeleteArchivoInputPort
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadRepository<Archivo,int> _readRepository;
    private readonly IDeleteArchivoOutputPort _outputPort;

    public DeleteArchivoInteractor(IUnitOfWork unitOfWork, 
        IDeleteArchivoOutputPort outputPort,
        IReadRepository<Archivo,int> readRepository)
    {
        _unitOfWork = unitOfWork;
        _outputPort = outputPort;
        _readRepository = readRepository;
    }
    
    public async ValueTask Handle(int archivoId)
    {
        var archivo = await _readRepository.GetByIdAsync(archivoId);
        
        if(archivo == null) throw new Exception("El archivo no existe");
        
        archivo.Activo = false;
        
        _unitOfWork.WriteRepository<Archivo>().UpdateEntity(archivo);

        var result = await _unitOfWork.Complete();
        
        //se evalua si funciono correctamente
        if (result <= 0)
        {
            throw new Exception("No se pudo eliminar el record de archivo");
        }

        await _outputPort.Handle(archivo.Id);
        
    }
}