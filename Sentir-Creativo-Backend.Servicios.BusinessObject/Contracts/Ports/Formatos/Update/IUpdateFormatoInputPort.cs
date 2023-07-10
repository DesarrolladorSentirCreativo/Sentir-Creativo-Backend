namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Update
{
    public interface IUpdateFormatoInputPort
    {
        ValueTask Handle(UpdateFormatoDto dto);
    }
}
