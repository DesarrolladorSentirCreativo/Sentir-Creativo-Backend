using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;

public interface ISelectOrigenOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectOrigenViewModel> modelView);
}