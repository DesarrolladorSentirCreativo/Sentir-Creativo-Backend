using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface ISelectTecnicaArtisticaPresenter : ISelectTecnicaArtisticaOutputPort
    {
        IReadOnlyList<SelectTecnicaArtisticaViewModel> ModelViews { get; }
    }
}
