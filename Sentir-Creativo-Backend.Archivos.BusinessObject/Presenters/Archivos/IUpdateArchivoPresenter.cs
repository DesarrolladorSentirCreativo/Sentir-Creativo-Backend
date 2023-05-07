using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Update;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

public interface IUpdateArchivoPresenter : IUpdateArchivoOutputPort
{
    int ArchivoId { get; }
}