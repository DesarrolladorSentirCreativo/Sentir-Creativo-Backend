namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos
{
    public interface IGetAllPublicoObjetivoController
    {
        ValueTask<IReadOnlyList<GetAllPublicoObjetivoViewModel>> Handle();
    }
}
