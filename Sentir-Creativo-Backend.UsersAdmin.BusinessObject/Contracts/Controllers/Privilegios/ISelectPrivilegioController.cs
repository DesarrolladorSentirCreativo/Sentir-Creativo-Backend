namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Privilegios;

public interface ISelectPrivilegioController
{
    ValueTask<IReadOnlyList<SelectPrivilegioViewModel>> Handle();
}