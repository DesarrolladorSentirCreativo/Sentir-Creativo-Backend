using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;
using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetByIdModuloPresenter : IGetByIdModuloOutputPort
{
    GetByIdModuloViewModel ModelView { get; }
}