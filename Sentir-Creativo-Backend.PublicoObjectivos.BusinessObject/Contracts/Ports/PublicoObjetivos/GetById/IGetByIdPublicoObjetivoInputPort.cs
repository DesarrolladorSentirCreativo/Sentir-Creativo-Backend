namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.GetById
{
    public interface IGetByIdPublicoObjetivoInputPort
    {
        ValueTask Handle(int publicoObjetivoId);
    }
}
