using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Create;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface ICreatePrivilegioPresenter : ICreatePrivilegioOutputPort
{
    string PrivilegioId { get; }
}