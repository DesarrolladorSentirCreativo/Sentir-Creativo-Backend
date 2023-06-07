using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AcuerdosUserAdmin;

public interface IUpdateAcuerdoUserAdminPresenter : IUpdateAcuerdoUserAdminOutputPort
{
    int AcuerdoId { get; }
}