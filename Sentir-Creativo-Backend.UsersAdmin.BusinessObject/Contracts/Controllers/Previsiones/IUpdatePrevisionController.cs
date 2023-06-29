namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface IUpdatePrevisionController
{
    ValueTask<int> Handle(UpdatePrevisionDto dto);
}