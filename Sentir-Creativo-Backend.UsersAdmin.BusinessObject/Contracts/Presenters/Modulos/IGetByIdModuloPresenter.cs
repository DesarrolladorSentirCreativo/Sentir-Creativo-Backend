namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetByIdModuloPresenter : IGetByIdModuloOutputPort
{
    GetByIdModuloViewModel ModelView { get; }
}