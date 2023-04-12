using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;

public interface ISelectFormatoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectFormatoViewModel> modelView);
}