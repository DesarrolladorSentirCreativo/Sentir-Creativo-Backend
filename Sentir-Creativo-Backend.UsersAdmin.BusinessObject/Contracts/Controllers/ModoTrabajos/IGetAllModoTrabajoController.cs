namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;

public interface IGetAllModoTrabajoController
{
    ValueTask<IReadOnlyList<GetAllModoTrabajoViewModel>> Handle();
}