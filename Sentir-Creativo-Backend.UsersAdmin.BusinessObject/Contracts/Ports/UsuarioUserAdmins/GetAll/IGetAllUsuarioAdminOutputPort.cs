namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.UsuarioUserAdmins.GetAll;

public interface IGetAllUsuarioAdminOutputPort
{
    ValueTask Handle(IReadOnlyList<GetAllUsuarioAdminViewModel> viewModels);
}