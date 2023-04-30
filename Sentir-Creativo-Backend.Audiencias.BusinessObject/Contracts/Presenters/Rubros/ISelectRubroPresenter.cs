using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Rubros.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Rubros;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Rubros;

public interface ISelectRubroPresenter : ISelectRubroOutputPort
{
    IReadOnlyList<SelectRubroViewModel> SelectRubros { get; }
}