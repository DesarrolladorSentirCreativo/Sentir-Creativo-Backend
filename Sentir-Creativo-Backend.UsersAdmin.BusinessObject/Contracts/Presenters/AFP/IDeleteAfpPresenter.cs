namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IDeleteAfpPresenter  : IDeleteAfpOutputPort
{
    int AfpId { get; }
}