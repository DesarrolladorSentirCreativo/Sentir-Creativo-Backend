namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.Select;

public interface ISelectFormatoOutputPort
{
    ValueTask Handle(IReadOnlyList<SelectFormatoViewModel> modelView);
}