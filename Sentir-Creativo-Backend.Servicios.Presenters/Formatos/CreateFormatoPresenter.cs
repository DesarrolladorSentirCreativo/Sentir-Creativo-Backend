namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos
{
    public class CreateFormatoPresenter : ICreateFormatoPresenter
    {
        public int FormatoId { get; private set; }

        public ValueTask Handle(int formatoId)
        {
            FormatoId = formatoId;

            return ValueTask.CompletedTask;
        }
    }
}
