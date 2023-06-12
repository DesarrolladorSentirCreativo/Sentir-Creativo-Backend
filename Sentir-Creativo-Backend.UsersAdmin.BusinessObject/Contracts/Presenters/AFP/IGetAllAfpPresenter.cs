using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IGetAllAfpPresenter : IGetAllAfpOutputPort
{
    IReadOnlyList<GetAllAfpViewModel> ViewModels { get; }
}