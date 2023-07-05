using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetAll
{
    public interface IGetAllTecnicaArtisticaOutputPort
    {
        ValueTask Handle(IReadOnlyList<GetAllTecnicaArtisticaViewModel> modelViews);

    }
}
