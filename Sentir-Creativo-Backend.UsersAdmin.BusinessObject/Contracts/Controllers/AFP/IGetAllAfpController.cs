namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IGetAllAfpController
{
    ValueTask<IReadOnlyList<GetAllAfpViewModel>> Handle();
}