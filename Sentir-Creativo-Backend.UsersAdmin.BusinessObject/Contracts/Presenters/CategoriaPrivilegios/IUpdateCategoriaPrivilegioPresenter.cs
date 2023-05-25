using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.CategoriaPrivilegios.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.CategoriaPrivilegios;

public interface IUpdateCategoriaPrivilegioPresenter : IUpdateCategoriaPrivilegioOutputPort
{
    int CategoriaPrivilegioId { get; }
}