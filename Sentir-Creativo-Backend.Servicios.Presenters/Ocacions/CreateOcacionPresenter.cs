namespace Sentir_Creativo_Backend.Servicios.Presenters.Ocacions
{
    public class CreateOcacionPresenter : ICreateOcacionPresenter
    {
        public int OcacionId { get; private set; }

        public ValueTask Handle(int Ocacionid)
        {
            OcacionId = OcacionId;

            return ValueTask.CompletedTask;
        }
    }
}

    

