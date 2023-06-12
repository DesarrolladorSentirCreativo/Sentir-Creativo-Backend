using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;

public interface IGetAllAfpOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllAfpViewModel> viewModels);
}