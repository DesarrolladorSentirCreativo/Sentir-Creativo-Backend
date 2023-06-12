namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IDeleteAfpController
{
    ValueTask<int> Handle(int afpId);
}