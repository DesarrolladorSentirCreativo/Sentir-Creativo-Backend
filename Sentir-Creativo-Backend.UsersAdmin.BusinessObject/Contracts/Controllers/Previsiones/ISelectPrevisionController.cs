namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface ISelectPrevisionController
{
    ValueTask<IReadOnlyList<SelectPrevisionViewModel>> Handle();
}