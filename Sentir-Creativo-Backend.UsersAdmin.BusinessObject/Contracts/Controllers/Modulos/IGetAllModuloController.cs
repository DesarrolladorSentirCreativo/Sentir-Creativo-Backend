namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface IGetAllModuloController
{
    ValueTask<IReadOnlyList<GetAllModuloViewModel>> Handle();
}