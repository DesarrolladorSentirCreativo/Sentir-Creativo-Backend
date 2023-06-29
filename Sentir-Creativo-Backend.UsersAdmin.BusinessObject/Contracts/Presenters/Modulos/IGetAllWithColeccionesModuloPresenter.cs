namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Presenters.Modulos;

public interface IGetAllWithColeccionesModuloPresenter : IGetAllWithColeccionesModuloOutputPort
{
    IReadOnlyList<GetAllWithColeccionesModuloViewModel> ModelViews { get; }
}