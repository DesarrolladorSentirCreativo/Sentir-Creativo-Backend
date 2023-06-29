namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.ColeccionesUserAdmin;

public interface ISelectColeccionUserAdminAdminPresenter : ISelectColeccionUserAdminOutputPort
{
    IReadOnlyList<SelectColeccionUserAdminViewModel> ModelViews { get; }
}