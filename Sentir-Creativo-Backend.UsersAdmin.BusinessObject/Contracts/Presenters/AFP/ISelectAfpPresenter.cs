namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface ISelectAfpPresenter : ISelectAfpOutputPort
{
    IReadOnlyList<SelectAfpViewModel>  ViewModels { get; }
}