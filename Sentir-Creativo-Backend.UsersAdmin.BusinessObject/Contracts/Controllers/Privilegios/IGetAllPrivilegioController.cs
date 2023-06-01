using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface IGetAllPrivilegioController
{
    ValueTask<IReadOnlyList<GetAllPrivilegioViewModel>> Handle();
}