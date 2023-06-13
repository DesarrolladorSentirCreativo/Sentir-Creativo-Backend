using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetAll;

public interface IGetAllModoTrabajoOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllModoTrabajoViewModel> viewModels);
}