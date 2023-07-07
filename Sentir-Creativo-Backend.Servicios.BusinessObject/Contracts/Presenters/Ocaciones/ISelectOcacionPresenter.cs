namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocaciones
{
    public interface ISelectOcacionPresenter : ISelectOcacionOutputPort
    {
        IReadOnlyList<SelectOcacionModelView> ModelViews { get; }
    }
}
