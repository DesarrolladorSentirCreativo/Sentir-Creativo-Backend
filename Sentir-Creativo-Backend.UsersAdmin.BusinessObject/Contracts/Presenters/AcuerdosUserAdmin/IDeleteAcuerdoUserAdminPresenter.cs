namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface IDeleteAcuerdoUserAdminPresenter : IDeleteAcuerdoUserAdminOutputPort
{
    int AcuerdoId { get; }
}