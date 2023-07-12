namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos
{
    public interface IDeletePublicoObjetivoController
    {
        ValueTask<int> Handle(int publicoObjetivoId);
    }
}
