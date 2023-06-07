using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AcuerdosUserAdmin;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AcuerdosUserAdmin.GetById;

public interface IGetByIdAcuerdoUserAdminOutputPort
{
    ValueTask Handle(GetByIdAcuerdoUserAdminViewModel modelView);
}