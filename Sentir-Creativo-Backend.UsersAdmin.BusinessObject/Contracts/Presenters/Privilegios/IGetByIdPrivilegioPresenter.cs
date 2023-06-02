using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Privilegios;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Privilegios;

public interface IGetByIdPrivilegioPresenter : IGetByIdPrivilegioOutputPort
{
    GetByIdPrivilegioViewModel ModelView { get; }
}