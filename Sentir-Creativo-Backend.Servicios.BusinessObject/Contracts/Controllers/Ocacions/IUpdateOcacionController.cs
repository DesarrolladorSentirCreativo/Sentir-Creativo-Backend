using Sentir_Creativo_Backend.Servicios.BusinessObject.Dtos.Ocacions;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public interface IUpdateOcacionController    {
        ValueTask<int> Handle( UpdateOcacionDto dto);
    }
}
