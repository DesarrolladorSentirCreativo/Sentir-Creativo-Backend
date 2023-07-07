namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.GetAll
{
    public interface IGetAllOcacionOutputPort
    {
        ValueTask Handle(IReadOnlyList<GetAllOcacionViewModel> viewModels);
    }
}
