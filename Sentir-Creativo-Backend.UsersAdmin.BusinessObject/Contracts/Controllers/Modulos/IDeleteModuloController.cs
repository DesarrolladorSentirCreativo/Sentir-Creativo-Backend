namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface IDeleteModuloController
{
    ValueTask<int> Handle(int moduloId);
}