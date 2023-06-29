namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface IGetAllWithColeccionesModuloController
{
    ValueTask<IReadOnlyList<GetAllWithColeccionesModuloViewModel>> Handle();
}