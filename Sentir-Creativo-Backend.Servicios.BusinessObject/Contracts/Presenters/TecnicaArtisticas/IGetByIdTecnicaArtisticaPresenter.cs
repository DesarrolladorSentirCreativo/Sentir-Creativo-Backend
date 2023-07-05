using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.TecnicaArtisticas
{
    public interface IGetByIdTecnicaArtisticaPresenter : IGetByIdTecnicaArtisticaOutputPort
    {
        GetByIdTecnicaArtisticaViewModel ViewModel { get; }
    }
}
