namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos
{
    public class UpdateFormatoPresenter : IUpdateFormatoPresenter
    {
        public int FormatoId { get; private set; }

        public ValueTask Handle(int formatoId)
        {
            FormatoId = formatoId;

            return ValueTask.CompletedTask;
        }
    }
}
