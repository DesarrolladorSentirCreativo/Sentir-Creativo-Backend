namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public interface IGetAllOcacionController
    {
        ValueTask<IReadOnlyList<GetAllOcacionViewModel>> Handle();
    }
}
