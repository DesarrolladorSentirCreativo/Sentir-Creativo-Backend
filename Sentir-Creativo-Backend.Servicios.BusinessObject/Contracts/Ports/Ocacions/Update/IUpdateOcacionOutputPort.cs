
namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Update
{
    public interface IUpdateOcacionOutputPort
    {
        ValueTask Handle(int ocacionId);
    }
}
