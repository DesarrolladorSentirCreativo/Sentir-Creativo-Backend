namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.GetById
{
    public interface IGetByIdFormatoInputPort
    {
        ValueTask Handle(int formatoId);
    }
}
