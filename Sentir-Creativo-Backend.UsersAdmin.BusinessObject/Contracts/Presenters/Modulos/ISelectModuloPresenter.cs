namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface ISelectModuloPresenter : ISelectModuloOutputPort
{
    IReadOnlyList<SelectModuloViewModel> ModelViews { get; }
}