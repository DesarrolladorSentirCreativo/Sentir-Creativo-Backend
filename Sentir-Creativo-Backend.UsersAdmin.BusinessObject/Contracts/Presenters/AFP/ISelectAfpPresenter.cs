using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Select;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface ISelectAfpPresenter : ISelectAfpOutputPort
{
    IReadOnlyList<SelectAfpViewModel>  ViewModels { get; }
}