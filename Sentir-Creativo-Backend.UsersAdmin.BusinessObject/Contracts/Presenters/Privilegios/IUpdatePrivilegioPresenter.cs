using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface IUpdatePrivilegioPresenter : IUpdatePrivilegioOutputPort
{
    string PrivilegioId { get; }
}