namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Presenters.PublicoObjetivos
{
    public interface IGetAllPublicoObjetivoPresenter : IGetAllPublicoObjetivoOutputPort
    {
        IReadOnlyList<GetAllPublicoObjetivoViewModel> ModelViews { get; }
    }
}
