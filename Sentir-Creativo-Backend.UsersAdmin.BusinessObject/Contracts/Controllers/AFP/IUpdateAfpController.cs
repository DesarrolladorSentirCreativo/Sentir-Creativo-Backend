namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Controllers.AFP;

public interface IUpdateAfpController
{
    ValueTask<int> Handle(UpdateAfpDto dto);
}