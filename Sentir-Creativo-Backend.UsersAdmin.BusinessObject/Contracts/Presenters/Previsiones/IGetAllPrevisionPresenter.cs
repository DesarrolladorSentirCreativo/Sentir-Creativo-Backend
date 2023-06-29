namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface IGetAllPrevisionPresenter : IGetAllPrevisionOutputPort
{
    IReadOnlyList<GetAllPrevisionViewModel> ViewModels { get; }
}