namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IGetByIdPrevisionPresenter : IGetByIdPrevisionOutputPort
{
    GetByIdPrevisionViewModel ViewModel { get; }
}