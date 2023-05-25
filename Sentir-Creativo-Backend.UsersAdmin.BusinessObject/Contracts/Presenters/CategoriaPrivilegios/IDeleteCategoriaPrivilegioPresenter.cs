using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface IDeleteCategoriaPrivilegioPresenter : IDeleteCategoriaPrivilegioOutputPort
{
    int CategoriaPrivilegioId { get; }
}