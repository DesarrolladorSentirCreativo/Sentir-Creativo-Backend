namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos
{
    public interface IGetByIdPublicoObjetivoController
    {
        ValueTask<GetByIdPublicoObjetivoViewModel> Handle(int publicoObjetivoId);
    }
}
