namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos
{
    public interface IGetByIdPublicoObjetivoPresenter : IGetByIdPublicoObjetivoOutputPort
    {
        GetByIdPublicoObjetivoViewModel ViewModel { get; }
    }
}
