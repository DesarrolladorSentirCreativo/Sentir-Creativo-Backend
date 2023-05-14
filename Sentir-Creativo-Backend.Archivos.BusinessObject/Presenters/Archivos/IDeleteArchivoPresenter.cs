using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Delete;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

public interface IDeleteArchivoPresenter : IDeleteArchivoOutputPort
{
    int ArchivoId { get;  }
}