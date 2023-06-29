namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface IGetAllModoTrabajoPresenter : IGetAllModoTrabajoOutputPort
{
    IReadOnlyList<GetAllModoTrabajoViewModel> ModelViews { get; }
}