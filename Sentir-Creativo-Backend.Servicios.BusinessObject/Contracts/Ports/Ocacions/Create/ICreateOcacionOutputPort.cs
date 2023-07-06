namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.Create
{
    public  interface ICreateOcacionOutputPort
    {
        ValueTask Handle(int OcacionId);
    }
}
