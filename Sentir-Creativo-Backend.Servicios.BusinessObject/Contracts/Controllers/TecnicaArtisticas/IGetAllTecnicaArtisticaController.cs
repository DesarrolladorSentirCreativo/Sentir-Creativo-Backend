using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.TecnicaArtisticas
{
    public interface IGetAllTecnicaArtisticaController
    {
        ValueTask<IReadOnlyList<GetAllTecnicaArtisticaViewModel>> Handle();
    }
}
