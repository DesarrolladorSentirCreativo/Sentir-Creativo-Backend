namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface IDeletePrivilegioController
{
    ValueTask<string> Handle(string privilegioId);
}