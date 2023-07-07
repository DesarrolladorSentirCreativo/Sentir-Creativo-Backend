namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Delete
{
    public interface IDeleteOcacionOutputPort
    {
        ValueTask Handle(int ocacionId);
    }
}
