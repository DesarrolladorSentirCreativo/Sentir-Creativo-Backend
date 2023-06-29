namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ColeccionesUserAdmin.Create;

public interface ICreateColeccionUserAdminInputPort
{
    ValueTask Handle(CreateColeccionUserAdminDto dto);
}