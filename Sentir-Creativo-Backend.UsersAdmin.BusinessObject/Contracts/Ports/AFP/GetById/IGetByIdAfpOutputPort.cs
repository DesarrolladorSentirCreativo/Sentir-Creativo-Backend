using Sentir_Creativo_Backend.UsersAdmin.BusinessObject.ViewModels.AFP;

namespace Sentir_Creativo_Backend.UsersAdmin.BusinessObject.Contracts.Ports.AFP.GetById;

public interface IGetByIdAfpOutputPort
{
    ValueTask Handle(GetByIdAfpViewModel viewModel);
}