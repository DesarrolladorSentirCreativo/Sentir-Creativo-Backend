namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.ModoTrabajos.Select;

public interface ISelectModoTrabajoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectModoTrabajoViewModel> viewModels);
}