namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Delete
{
    public interface IDeleteOcacionInputPort
    {
        ValueTask Handle(int ocacionId);
    }
}
