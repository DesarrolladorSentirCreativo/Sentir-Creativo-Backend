using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.DTO.ModoTrabajos;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;

public interface IUpdateModoTrabajoController
{
    ValueTask<int> Handle(UpdateModoTrabajoDto dto);
}