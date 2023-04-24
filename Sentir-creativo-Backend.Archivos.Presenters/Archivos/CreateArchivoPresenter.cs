using Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

namespace Sentir_creativo_Backend.Archivos.Presenters.Archivos;

public class CreateArchivoPresenter : ICreateArchivoPresenter
{
    public int ArchivoId { get; private set;  }
    
    public ValueTask Handle(int archivoId)
    {
        ArchivoId = archivoId;
        
        return ValueTask.CompletedTask;
    }
}