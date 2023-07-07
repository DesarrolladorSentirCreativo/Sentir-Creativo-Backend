namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Ports.Ocacions.GetById
{
    public interface IGetByIdOcacionOutputPort
    {
        ValueTask Handle(GetByIdOcacionViewModel viewModel);
    }
}
