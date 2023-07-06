using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Update;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocacions
{
    public interface IUpdateOcacionPresenter :IUpdateOcacionOutputPort
    {
       int  OcacionId { get; }

        
    }
}
