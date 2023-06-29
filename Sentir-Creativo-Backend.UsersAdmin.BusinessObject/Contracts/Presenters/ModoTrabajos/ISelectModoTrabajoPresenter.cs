namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface ISelectModoTrabajoPresenter : ISelectModoTrabajoOutputPort
{
    IReadOnlyList<SelectModoTrabajoViewModel> ModelViews { get; }
}