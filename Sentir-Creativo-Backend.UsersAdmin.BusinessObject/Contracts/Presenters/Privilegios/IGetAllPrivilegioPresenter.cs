namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface IGetAllPrivilegioPresenter : IGetAllPrivilegioOutputPort
{
    IReadOnlyList<GetAllPrivilegioViewModel> ModelViews { get; }
}