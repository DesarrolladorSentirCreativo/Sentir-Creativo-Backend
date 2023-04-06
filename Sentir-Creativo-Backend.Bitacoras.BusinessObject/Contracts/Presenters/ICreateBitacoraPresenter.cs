using Sentir_Creativo_Backend.Bitacoras.BusinessObject.Contracts.Ports;

namespace Sentir_Creativo_Backend.Bitacoras.BusinessObject.Contracts.Presenters;

public interface ICreateBitacoraPresenter : ICreateBitacoraOutputPort
{
    int BitacoraId { get; }
}