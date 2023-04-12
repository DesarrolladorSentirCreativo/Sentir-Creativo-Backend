using Sentir_Creativo_Backend.Areas.BusinessObject.ViewModels.Areas;

namespace Sentir_Creativo_Backend.Areas.BusinessObject.Contracts.Ports.Areas.Select;

public interface ISelectAreaOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectAreaViewModel> modelView);
}