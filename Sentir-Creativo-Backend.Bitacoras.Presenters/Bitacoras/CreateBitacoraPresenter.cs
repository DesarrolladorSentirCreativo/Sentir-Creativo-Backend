using Sentir_Creativo_Backend.Bitacoras.BusinessObjects.Presenters.Bitacoras;

namespace Sentir_Creativo_Backend.Bitacoras.Presenters.Bitacoras;

public class CreateBitacoraPresenter : ICreateBitacoraPresenter
{
    public int BitacoraId { get; private set; }
    
    public ValueTask Handle(int bitacoraId)
    {
        BitacoraId = bitacoraId;
        
        return ValueTask.CompletedTask;
    }
}