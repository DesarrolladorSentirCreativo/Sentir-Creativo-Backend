namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetAllModuloPresenter : IGetAllModuloOutputPort
{
    IReadOnlyList<GetAllModuloViewModel> ModelViews { get; }
}