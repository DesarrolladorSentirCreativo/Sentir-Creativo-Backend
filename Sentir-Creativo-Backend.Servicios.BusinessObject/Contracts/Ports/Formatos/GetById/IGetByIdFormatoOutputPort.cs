namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.GetById
{
    public interface IGetByIdFormatoOutputPort
    {
        ValueTask Handle(GetByIdFormatoViewModel viewModel);
    }
}
