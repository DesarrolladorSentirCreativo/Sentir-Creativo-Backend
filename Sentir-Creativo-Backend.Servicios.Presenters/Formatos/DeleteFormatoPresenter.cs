namespace Sentir_Creativo_Backend.Servicios.Presenters.Formatos
{
    public class DeleteFormatoPresenter : IDeleteFormatoPresenter
    {
        public int FormatoId { get; private set; }

        public ValueTask Handle(int formatoId)
        {
            FormatoId = formatoId;

            return ValueTask.CompletedTask;
        }
    }
}
