namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.ModoTrabajos;

public interface IDeleteModoTrabajoController
{
    ValueTask<int> Handle(int modoTrabajoId);
}