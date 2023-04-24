using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Ports.Bitacoras.Create;

namespace Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Presenters.Bitacoras;

public interface ICreateBitacoraPresenter : ICreateBitacoraOutputPort
{
    public int BitacoraId { get; }
}