namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos
{
    public interface IUpdatePublicoObjetivoPresenter : IUpdatePublicoObjetivoOutputPort
    {
        int PublicoObjetivoId { get; }
    }
}
