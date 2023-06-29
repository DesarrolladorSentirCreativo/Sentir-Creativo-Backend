namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.GetById;

public interface IGetByIdModoTrabajoOutputPort
{
    ValueTask Handle(GetByIdModoTrabajoViewModel viewModel);
}