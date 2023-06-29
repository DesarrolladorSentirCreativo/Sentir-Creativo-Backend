namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface ICreateAfpController
{
    ValueTask<int> Handle(CreateAfpDto dto);
}