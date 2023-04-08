using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Motivaciones;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Motivaciones.Select;

public interface ISelectMotivacionOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectMotivacionViewModel> modelView);
}