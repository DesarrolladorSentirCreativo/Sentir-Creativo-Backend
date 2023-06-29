namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetAll;

public interface IGetAllAfpOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllAfpViewModel> viewModels);
}