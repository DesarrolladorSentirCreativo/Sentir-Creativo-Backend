namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface ICreatePrivilegioController
{
    ValueTask<string> Handle(CreatePrivilegioDto dto);
}