using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface IGetByIdPrivilegioController
{
    ValueTask<GetByIdPrivilegioViewModel> Handle(string privilegioId);
}