using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface ICreateAfpPresenter : ICreateAfpOutputPort
{
    int AfpId { get; }
}