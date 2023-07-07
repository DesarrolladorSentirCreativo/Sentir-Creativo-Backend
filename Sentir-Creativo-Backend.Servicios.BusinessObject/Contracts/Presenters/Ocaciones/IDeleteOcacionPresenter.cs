using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Delete;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocaciones
{
    public interface IDeleteOcacionPresenter : IDeleteOcacionOutputPort
    {
        int OcacionId { get; }
    }
}
