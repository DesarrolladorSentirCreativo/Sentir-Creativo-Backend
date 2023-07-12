namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos
{
    public interface ICreatePublicoObjetivoController
    {
        ValueTask<int> Handle(CreatePublicoObjetivoDto dto);
    }
}
