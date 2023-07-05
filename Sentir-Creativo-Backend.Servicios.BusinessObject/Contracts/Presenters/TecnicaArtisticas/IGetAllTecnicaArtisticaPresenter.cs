using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface IGetAllTecnicaArtisticaPresenter : IGetAllTecnicaArtisticaOutputPort
    {
        IReadOnlyList<GetAllTecnicaArtisticaViewModel> ModelViews { get; }
    }
}
