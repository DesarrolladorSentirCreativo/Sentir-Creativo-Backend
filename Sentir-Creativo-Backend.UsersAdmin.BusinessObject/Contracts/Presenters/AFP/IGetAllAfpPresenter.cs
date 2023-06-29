namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IGetAllAfpPresenter : IGetAllAfpOutputPort
{
    IReadOnlyList<GetAllAfpViewModel> ViewModels { get; }
}