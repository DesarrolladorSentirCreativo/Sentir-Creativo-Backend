namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface ICreateModuloController
{
    ValueTask<int> Handle(CreateModuloDto dto);
}