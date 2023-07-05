using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.TecnicaArtistica;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.TecnicaArtistica.GetById
{
    public interface IGetByIdTecnicaArtisticaOutputPort
    {
        ValueTask Handle(GetByIdTecnicaArtisticaViewModel viewModel);
    }
}
