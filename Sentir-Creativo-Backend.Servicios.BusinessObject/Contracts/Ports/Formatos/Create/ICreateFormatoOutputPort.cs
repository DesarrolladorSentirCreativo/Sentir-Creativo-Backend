namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Create
{
    public interface ICreateFormatoOutputPort
    {
        ValueTask Handle(int formatoId);
    }
}
