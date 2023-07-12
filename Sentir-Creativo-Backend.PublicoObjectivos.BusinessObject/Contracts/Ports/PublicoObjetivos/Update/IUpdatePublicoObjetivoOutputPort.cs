namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Update
{
    public interface IUpdatePublicoObjetivoOutputPort
    {
        ValueTask Handle(int publicoObjetivoId);
    }
}
