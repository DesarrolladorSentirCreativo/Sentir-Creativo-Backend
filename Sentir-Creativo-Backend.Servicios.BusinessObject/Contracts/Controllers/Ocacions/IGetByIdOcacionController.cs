namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public interface IGetByIdOcacionController
    {
        ValueTask<GetByIdOcacionViewModel> Handle(int ocacionId);
    }
}
