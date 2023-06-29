namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface IGetByIdAcuerdoUserAdminPresenter : IGetByIdAcuerdoUserAdminOutputPort
{
    GetByIdAcuerdoUserAdminViewModel ModelView { get; }
}