using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Antiguedades;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Antiguedades.Select;

public interface ISelectAntiguedadOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectAntiguedadViewModel> modelView);
}