using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.Select
{
    public interface ISelectTecnicaArtisticaOutputPort
    {
        ValueTask Handle(IReadOnlyList<SelectTecnicaArtisticaViewModel> modelViews);
    }
}
