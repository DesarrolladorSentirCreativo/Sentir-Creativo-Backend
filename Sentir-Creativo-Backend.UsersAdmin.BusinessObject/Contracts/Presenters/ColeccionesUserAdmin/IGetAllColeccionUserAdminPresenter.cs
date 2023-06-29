namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface IGetAllColeccionUserAdminPresenter : IGetAllColeccionUserAdminOutputPort
{
    IReadOnlyList<GetAllColeccionUserAdminViewModel> ModelViews { get; }
}