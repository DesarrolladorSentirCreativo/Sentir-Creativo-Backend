namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Formatos.GetAll
{
    public interface IGetAllFormatoOutputPort
    {
        ValueTask Handle(IReadOnlyList<GetAllFormatoViewModel> viewModels);
    }
}
