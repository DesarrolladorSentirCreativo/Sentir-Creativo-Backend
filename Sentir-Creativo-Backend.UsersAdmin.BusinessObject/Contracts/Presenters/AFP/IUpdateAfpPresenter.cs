using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IUpdateAfpPresenter : IUpdateAfpOutputPort
{
    int AfpId { get; }
}