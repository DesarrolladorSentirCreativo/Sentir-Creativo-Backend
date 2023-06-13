namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface IDeletePrevisionController
{
    ValueTask<int> Handle(int previsionId);
}