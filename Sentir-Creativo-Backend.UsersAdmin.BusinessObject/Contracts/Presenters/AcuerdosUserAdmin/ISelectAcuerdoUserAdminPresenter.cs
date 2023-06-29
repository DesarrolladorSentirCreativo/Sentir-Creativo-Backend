namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface ISelectAcuerdoUserAdminPresenter : ISelectAcuerdoUserAdminOutputPort
{
    IReadOnlyList<SelectAcuerdoUserAdminViewModel> ModelViews { get; }
}