namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Update
{
    public interface IUpdateFormatoOutputPort
    {
        ValueTask Handle(int formatoId);
    }
}
