namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.AFP;

public interface IGetByIdAfpPresenter : IGetByIdAfpOutputPort
{
    GetByIdAfpViewModel ViewModel { get; }
}