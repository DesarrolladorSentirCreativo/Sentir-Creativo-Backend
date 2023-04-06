using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Antiguedades;

public interface ISelectAntiguedadPresenter : ISelectAntiguedadOutputPort
{
    IReadOnlyList<SelectAntiguedadViewModel> SelectAntiguedadViewModel { get; }
}