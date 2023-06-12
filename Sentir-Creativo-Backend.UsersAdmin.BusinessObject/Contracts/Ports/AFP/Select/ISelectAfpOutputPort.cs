using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Select;

public interface ISelectAfpOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectAfpViewModel> viewModels);
}