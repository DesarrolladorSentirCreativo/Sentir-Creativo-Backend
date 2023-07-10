namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Delete
{
    public interface IDeleteFormatoInputPort
    {
        ValueTask Handle(int formatoId);
    }
}
