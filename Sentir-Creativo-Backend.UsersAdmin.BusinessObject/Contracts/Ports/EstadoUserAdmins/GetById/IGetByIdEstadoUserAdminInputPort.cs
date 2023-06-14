namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.EstadoUserAdmins.GetById;

public interface IGetByIdEstadoUserAdminInputPort
{
    ValueTask Handle(int estadoId);
}