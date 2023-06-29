namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Modulos;

public interface IGetByIdModuloController
{
    ValueTask<GetByIdModuloViewModel> Handle(int moduloId);
}