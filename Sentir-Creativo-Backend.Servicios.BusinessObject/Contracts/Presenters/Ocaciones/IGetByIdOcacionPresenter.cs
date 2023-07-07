namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Ocaciones
{
    public interface IGetByIdOcacionPresenter : IGetByIdOcacionOutputPort
    {
        GetByIdOcacionViewModel ViewModel { get; }
    }
}
