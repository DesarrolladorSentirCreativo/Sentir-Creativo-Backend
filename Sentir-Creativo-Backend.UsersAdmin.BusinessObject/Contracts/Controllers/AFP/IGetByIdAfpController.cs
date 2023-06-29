

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IGetByIdAfpController
{
    ValueTask<GetByIdAfpViewModel> Handle(int afpId);
}