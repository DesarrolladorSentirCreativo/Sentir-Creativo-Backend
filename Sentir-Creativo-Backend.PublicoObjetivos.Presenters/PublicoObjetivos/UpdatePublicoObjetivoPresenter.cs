namespace Sentir_Creativo_Backend.PublicoObjetivos.Presenters.PublicoObjetivos
{
    public class UpdatePublicoObjetivoPresenter : IUpdatePublicoObjetivoPresenter
    {
        public int PublicoObjetivoId { get; private set; }
        public ValueTask Handle(int publicoObjetivoId)
        {
            PublicoObjetivoId = publicoObjetivoId;

            return ValueTask.CompletedTask;
        }
    }
}
