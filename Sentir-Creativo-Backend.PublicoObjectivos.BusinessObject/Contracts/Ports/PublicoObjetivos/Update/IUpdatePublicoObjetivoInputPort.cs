namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Update
{
    public interface IUpdatePublicoObjetivoInputPort
    {
        ValueTask Handle(UpdatePublicoObjetivoDto dto);
    }
}
