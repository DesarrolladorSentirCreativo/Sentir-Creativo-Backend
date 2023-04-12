using Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;
using Sentir_Creativo_Backend.Servicios.BusinessObject.ViewModels.Formatos;

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos;

public interface ISelectFormatoPresenter : ISelectFormatoOutputPort
{
    IReadOnlyList<SelectFormatoViewModel> SelectFormatoViewModel { get; }
}