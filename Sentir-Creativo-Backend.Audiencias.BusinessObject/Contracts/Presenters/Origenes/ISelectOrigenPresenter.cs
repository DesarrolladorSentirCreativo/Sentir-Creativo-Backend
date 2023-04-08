using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Origenes.SelectOrigen;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Origenes;

public interface ISelectOrigenPresenter : ISelectOrigenOutputPort
{
    IReadOnlyList<SelectOrigenViewModel> SelectOrigenViewModel { get; }
}