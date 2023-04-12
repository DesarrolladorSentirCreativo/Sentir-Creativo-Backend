using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Formatos;

public interface ISelectFormatoController
{
    ValueTask<IReadOnlyList<SelectFormatoViewModel>> Handle();
}