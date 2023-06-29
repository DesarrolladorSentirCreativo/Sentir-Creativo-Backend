namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Create;

public interface ICreateModuloInputPort
{
    ValueTask Handle(CreateModuloDto dto);
}