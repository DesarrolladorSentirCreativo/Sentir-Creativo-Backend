namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos
{
    public interface IGetByIdFormatoPresenter : IGetByIdFormatoOutputPort
    {
        GetByIdFormatoViewModel ViewModel { get; }
    }
}
