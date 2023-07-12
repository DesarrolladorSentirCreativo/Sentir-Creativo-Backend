namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos
{
    public interface IDeletePublicoObjetivoPresenter : IDeletePublicoObjetivoOutputPort
    {
        int PublicoObjetivoId { get; }
    }
}
