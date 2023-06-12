using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IGetByIdAfpPresenter : IGetByIdAfpOutputPort
{
    GetByIdAfpViewModel ViewModel { get; }
}