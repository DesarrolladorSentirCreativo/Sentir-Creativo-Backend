using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocacions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class CreateOcacionPresenter : ICreateOcacionPresenter
    {
        public int OcacionId { get; private set; }

        public ValueTask Handle(int Ocacionid)
        {
            OcacionId = OcacionId;

            return ValueTask.CompletedTask;
        }
    }
}

    

