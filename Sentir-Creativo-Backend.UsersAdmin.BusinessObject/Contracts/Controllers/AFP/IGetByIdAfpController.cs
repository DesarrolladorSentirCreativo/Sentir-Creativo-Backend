using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IGetByIdAfpController
{
    ValueTask<GetByIdAfpViewModel> Handle(int afpId);
}