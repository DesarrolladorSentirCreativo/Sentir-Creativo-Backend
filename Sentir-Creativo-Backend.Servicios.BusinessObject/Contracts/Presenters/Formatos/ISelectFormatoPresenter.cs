

namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Presenters.Formatos;

public interface ISelectFormatoPresenter : ISelectFormatoOutputPort
{
    IReadOnlyList<SelectFormatoViewModel> SelectFormatoViewModel { get; }
}