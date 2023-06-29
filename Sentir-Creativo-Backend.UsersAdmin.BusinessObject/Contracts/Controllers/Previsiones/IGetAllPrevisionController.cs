namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface IGetAllPrevisionController
{
    ValueTask<IReadOnlyList<GetAllPrevisionViewModel>> Handle();
}