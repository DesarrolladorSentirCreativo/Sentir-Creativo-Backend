using Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Ports.Cercanias.Select;
using Sentir_Creativo_Backend.Audiencia.BusinessObject.ViewModels.Cercanias;

namespace Sentir_Creativo_Backend.Audiencia.BusinessObject.Contracts.Presenters.Cercanias;

public interface ISelectCercaniaPresenter : ISelectCercaniaOutputPort
{
    IReadOnlyList<SelectCercaniaViewModel> SelectCercaniaViewModel { get; }
}