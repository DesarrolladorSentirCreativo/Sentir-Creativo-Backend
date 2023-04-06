using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Prefijos;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Prefijos.Select;

public interface ISelectPrefijoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectPrefijoViewModel> modelView);
}
