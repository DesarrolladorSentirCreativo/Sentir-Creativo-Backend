namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Previsiones;

public interface ISelectPrevisionPresenter : ISelectPrevisionOutputPort
{
    IReadOnlyList<SelectPrevisionViewModel> ViewModels { get; }
}