namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Delete
{
    public interface IDeletePublicoObjetivoOutputPort
    {
        ValueTask Handle(int publicoObjetivoId);
    }
}
