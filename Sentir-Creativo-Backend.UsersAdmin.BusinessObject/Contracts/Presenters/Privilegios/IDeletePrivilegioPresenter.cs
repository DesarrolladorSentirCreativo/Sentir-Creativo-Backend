using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface IDeletePrivilegioPresenter : IDeletePrivilegioOutputPort
{
    string PrivilegioId { get;  }
}