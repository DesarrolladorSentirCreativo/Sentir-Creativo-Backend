namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public interface IDeleteOcacionController
    {
        ValueTask<int> Handle(int ocacionId);
    }
}
