namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.Select;

public interface ISelectPrevisionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectPrevisionViewModel> viewModels);
}