namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class DeleteOcacionPresenter : IDeleteOcacionPresenter
    {
        public int OcacionId { get; private set; }

        public ValueTask Handle(int ocacionId)
        {
            OcacionId = ocacionId;

            return ValueTask.CompletedTask;
        }
    }
}
