

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;

public interface ICreateModoTrabajoController
{
    ValueTask<int> Handle(CreateModoTrabajoDto dto);
}