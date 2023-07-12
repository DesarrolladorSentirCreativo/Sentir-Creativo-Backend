namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Create
{
    public interface ICreatePublicoObjetivoOutputPort
    {
        ValueTask Handle(int publicoObjetivoId);
    }
}
