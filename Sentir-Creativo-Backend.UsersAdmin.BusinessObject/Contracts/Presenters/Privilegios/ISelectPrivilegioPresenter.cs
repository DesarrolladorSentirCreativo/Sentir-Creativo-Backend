namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface ISelectPrivilegioPresenter : ISelectPrivilegioOutputPort
{
    IReadOnlyList<SelectPrivilegioViewModel> ModelViews { get; }
}