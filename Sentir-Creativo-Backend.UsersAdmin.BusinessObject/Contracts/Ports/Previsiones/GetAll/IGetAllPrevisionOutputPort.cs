namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Previsiones.GetAll;

public interface IGetAllPrevisionOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllPrevisionViewModel> viewModels);
}