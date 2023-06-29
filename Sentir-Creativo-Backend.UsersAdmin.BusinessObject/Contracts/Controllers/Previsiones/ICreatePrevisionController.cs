namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface ICreatePrevisionController
{
    ValueTask<int> Handle(CreatePrevisionDto dto);
}