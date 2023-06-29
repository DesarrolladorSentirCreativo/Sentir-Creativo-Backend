namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface IGetByIdColeccionUserAdminPresenter : IGetByIdColeccionUserAdminOutputPort
{
    GetByIdColeccionUserAdminViewModel GetByIdColeccionUserAdminViewModel { get; }
}