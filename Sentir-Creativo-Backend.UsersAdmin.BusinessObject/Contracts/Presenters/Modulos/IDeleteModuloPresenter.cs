using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Delete;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IDeleteModuloPresenter : IDeleteModuloOutputPort
{
    int ModuloId { get; }
}