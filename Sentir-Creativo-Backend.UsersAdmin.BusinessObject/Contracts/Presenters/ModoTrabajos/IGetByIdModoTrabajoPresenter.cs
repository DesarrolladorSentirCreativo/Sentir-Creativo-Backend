namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ModoTrabajos;

public interface IGetByIdModoTrabajoPresenter : IGetByIdModoTrabajoOutputPort
{
    GetByIdModoTrabajoViewModel ModelView { get; }
}