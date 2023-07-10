namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Delete
{
    public interface IDeleteFormatoOutputPort
    {
        ValueTask Handle(int formatoId);
    }
}
