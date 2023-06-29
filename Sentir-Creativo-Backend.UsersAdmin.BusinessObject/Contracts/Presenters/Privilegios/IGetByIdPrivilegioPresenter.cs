namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;
public interface IGetByIdPrivilegioPresenter : IGetByIdPrivilegioOutputPort
{
    GetByIdPrivilegioViewModel ModelView { get; }
}