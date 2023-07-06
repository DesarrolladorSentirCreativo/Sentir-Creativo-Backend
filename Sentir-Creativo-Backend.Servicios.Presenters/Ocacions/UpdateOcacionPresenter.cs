
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions;
using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocacions;

namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class UpdateOcacionPresenter : IUpdateOcacionPresenter
    {

        public int OcacionId { get; private set; }
      
        public ValueTask Handle(int ocacionId)
        {
            OcacionId = ocacionId;

            return ValueTask.CompletedTask;
        }
    }
}

