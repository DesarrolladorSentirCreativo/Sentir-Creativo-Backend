namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface IGetByIdPrevisionController
{
    ValueTask<GetByIdPrevisionViewModel> Handle(int previsionId);
}