using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetById;

public interface IGetByIdPrevisionOutputPort
{
    ValueTask Handle(GetByIdPrevisionViewModel viewModel);
}