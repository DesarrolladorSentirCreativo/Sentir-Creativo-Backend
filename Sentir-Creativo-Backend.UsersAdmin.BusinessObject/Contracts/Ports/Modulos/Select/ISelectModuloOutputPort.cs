namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.Select;

public interface ISelectModuloOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectModuloViewModel> modelViews);
}