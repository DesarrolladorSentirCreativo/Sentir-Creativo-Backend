using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IGetAllAfpController
{
    ValueTask<IReadOnlyList<GetAllAfpViewModel>> Handle();
}