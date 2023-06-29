namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.Privilegios.GetAll;

public interface IGetAllPrivilegioOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllPrivilegioViewModel> modelViews);
}