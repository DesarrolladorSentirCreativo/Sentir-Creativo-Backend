namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface ISelectModuloController
{
    ValueTask<IReadOnlyList<SelectModuloViewModel>> Handle();
}