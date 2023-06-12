using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface ISelectAfpController
{
    ValueTask<IReadOnlyList<SelectAfpViewModel>> Handle();
}