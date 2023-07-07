namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.GetById
{
    public interface IGetByIdOcacionInputPort
    {
        ValueTask Handle(int ocacionId);
    }
}
