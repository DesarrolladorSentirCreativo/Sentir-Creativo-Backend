namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Update;

public interface IUpdateColeccionUserAdminInputPort
{
    ValueTask Handle(UpdateColeccionUserAdminDto dto);
}