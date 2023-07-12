namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Ports.PublicoObjetivos.Create
{
    public interface ICreatePublicoObjetivoInputPort
    {
        ValueTask Handle(CreatePublicoObjetivoDto dto);
    }
}
