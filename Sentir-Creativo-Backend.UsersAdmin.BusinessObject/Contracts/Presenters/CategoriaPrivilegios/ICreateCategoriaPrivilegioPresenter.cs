using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface ICreateCategoriaPrivilegioPresenter : ICreateCategoriaPrivilegioOutputPort
{
    int CategoriaPrivilegioId { get; }
}