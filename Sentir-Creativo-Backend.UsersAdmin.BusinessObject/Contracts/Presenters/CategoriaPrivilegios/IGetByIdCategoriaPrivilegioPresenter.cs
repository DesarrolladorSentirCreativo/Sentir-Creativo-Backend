namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface IGetByIdCategoriaPrivilegioPresenter : IGetByIdCategoriaPrivilegioOutputPort
{
    GetByIdCategoriaPrivilegioViewModel ModelView { get; }
}