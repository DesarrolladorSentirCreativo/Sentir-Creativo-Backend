using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface ICreateAcuerdoUserAdminPresenter : ICreateAcuerdoUserAdminOutputPort
{
    int AcuerdoId { get; }
}