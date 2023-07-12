namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Delete
{
    public interface IDeletePublicoObjetivoInputPort
    {
        ValueTask Handle(int publicoObjetivoId);
    }
}
