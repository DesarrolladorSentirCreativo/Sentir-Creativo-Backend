using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.Previsiones;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.Previsiones;

public interface ICreatePrevisionController
{
    ValueTask<int> Handle(CreatePrevisionDto dto);
}