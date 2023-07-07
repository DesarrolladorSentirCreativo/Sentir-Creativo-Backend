namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocaciones
{
    public interface IGetAllOcacionPresenter : IGetAllOcacionOutputPort
    {
        IReadOnlyList<GetAllOcacionViewModel> ViewModels { get; }
    }
}
