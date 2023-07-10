namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Create
{
    public interface ICreateFormatoInputPort
    {
        ValueTask Handle(CreateFormatoDto dto);
    }
}
