namespace Sentir_Creativo_Backend.Servicios.BusinessObject.Contracts.Controllers.Ocacions
{
    public interface ISelectOcacionController
    {
        ValueTask<IReadOnlyList<SelectOcacionModelView>> Handle();
    }
}
