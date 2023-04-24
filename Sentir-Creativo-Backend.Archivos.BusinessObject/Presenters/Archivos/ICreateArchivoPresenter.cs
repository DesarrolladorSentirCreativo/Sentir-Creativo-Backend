using Sentir_Creativo_Backend.Archivos.BusinessObject.Ports.Archivos.Create;

namespace Sentir_Creativo_Backend.Archivos.BusinessObject.Presenters.Archivos;

public interface ICreateArchivoPresenter : ICreateArchivoOutputPort
{
    public int ArchivoId { get; }
}