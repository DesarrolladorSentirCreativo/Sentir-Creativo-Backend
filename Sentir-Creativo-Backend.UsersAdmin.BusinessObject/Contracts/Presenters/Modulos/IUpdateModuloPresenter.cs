using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Update;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IUpdateModuloPresenter : IUpdateModuloOutputPort
{
    int ModuloId { get; }
}