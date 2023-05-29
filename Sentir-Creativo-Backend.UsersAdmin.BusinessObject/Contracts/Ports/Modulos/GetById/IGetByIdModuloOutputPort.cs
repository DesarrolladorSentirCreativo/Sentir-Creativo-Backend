using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Modulos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Modulos.GetById;

public interface IGetByIdModuloOutputPort
{
    ValueTask Handle(GetByIdModuloViewModel modelView);
}