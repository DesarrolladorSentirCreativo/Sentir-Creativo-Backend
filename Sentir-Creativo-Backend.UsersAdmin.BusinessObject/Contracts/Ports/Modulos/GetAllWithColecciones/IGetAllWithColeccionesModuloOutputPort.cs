namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetAllWithColecciones;

public interface IGetAllWithColeccionesModuloOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllWithColeccionesModuloViewModel> modelViews);
}