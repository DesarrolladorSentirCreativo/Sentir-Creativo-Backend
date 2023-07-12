namespace Sentir_Creativo_Backend.PublicoObjectivos.BusinessObject.Contracts.Controllers.PublicoObjetivos
{
    public interface IUpdatePublicoObjetivoController
    {
        ValueTask<int> Handle(UpdatePublicoObjetivoDto dto);
    }
}
